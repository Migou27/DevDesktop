using System.Data.SQLite;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BiblioGame
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            btn_notation.Enabled = false;
            btn_notation.Visible = false;
            btn_suppr.Enabled = false;
            btn_suppr.Visible = false;
        }

        private Jeu jeuChoisi;
        List<Jeu> lesJeux = new List<Jeu>();
        List<Jeu> jeuxFiltres1 = new List<Jeu>();
        List<Jeu> jeuxFiltres2 = new List<Jeu>();
        List<Jeu> jeuxFiltres3 = new List<Jeu>();
        private SortOrder sortOrder = SortOrder.None;
        private int lastSortedColumn = -1;

        private void ListViewRenderer(List<Jeu> liste)
        {
            lv_listeJeux.Items.Clear();
            foreach (Jeu unJeu in liste)
            {
                ListViewItem list = new ListViewItem(unJeu.getNomJeux());
                list.SubItems.Add(unJeu.getConsoleJeux());
                list.SubItems.Add(unJeu.getSortieJeux().ToString("dd MMM yyyy"));
                list.SubItems.Add(unJeu.getEditeurJeux());
                list.SubItems.Add(unJeu.getMoyenne() + "/5");
                list.Tag = unJeu;
                lv_listeJeux.Items.Add(list);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            Database db = new Database();
            lesJeux = db.getLesJeux("Select idJeux, nomJeux, consoleJeux, sortieJeux, editeurJeux, imageJeux, ROUND(AVG(note), 1) as Moyenne from jeux inner join noter on idJeux = idJeuxNoter group by idJeux");
            ListViewRenderer(lesJeux);
        }

        private void lv_listeJeux_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lastSortedColumn)
            {
                if (sortOrder == SortOrder.Ascending)
                {
                    sortOrder = SortOrder.Descending;
                }
                else
                {
                    sortOrder = SortOrder.Ascending;
                }
            }
            else
            {
                sortOrder = SortOrder.Ascending;
            }

            lastSortedColumn = e.Column;

            lv_listeJeux.ListViewItemSorter = new ListViewSorter(e.Column, sortOrder);
            lv_listeJeux.Sort();
        }

        private void lv_listeJeux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_listeJeux.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_listeJeux.SelectedItems[0];
                Jeu selectedJeu = selectedItem.Tag as Jeu;
                string imageUrl = selectedJeu.getImageJeux();

                pb_jeuAccueil.ImageLocation = imageUrl;

                pb_jeuAccueil.SizeMode = PictureBoxSizeMode.StretchImage;

                jeuChoisi = selectedJeu;
                btn_notation.Enabled = true;
                btn_notation.Visible = true;
                btn_suppr.Enabled = true;
                btn_suppr.Visible = true;
            }
        }

        private void rechercheListView()
        {
            if (tb_rechercheNom.Text != "")
            {
                this.jeuxFiltres1 = this.lesJeux.Where(x => x.getNomJeux().StartsWith(tb_rechercheNom.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                ListViewRenderer(jeuxFiltres1);
            }
            if (tb_rechercheConsole.Text != "")
            {
                this.jeuxFiltres2 = this.jeuxFiltres1.Where(x => x.getConsoleJeux().StartsWith(tb_rechercheConsole.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                ListViewRenderer(jeuxFiltres2);
            }
            if (tb_rechercheEditeur.Text != "")
            {
                this.jeuxFiltres3 = this.jeuxFiltres2.Where(x => x.getEditeurJeux().StartsWith(tb_rechercheEditeur.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                ListViewRenderer(jeuxFiltres3);
            }
            if (tb_rechercheNom.Text == "" && tb_rechercheConsole.Text == "" && tb_rechercheEditeur.Text == "")
            {
                ListViewRenderer(lesJeux);
            }
        }

        private void tb_recherche_TextChanged(object sender, EventArgs e)
        {
            rechercheListView();
        }

        private void tb_rechercheConsole_TextChanged(object sender, EventArgs e)
        {
            rechercheListView();
        }

        private void tb_recehercheEditeur_TextChanged(object sender, EventArgs e)
        {
            rechercheListView();
        }

        private void btn_notation_Click(object sender, EventArgs e)
        {
            Notation notation = new Notation(jeuChoisi);
            notation.Show();
            this.Hide();
        }

        private void btn_suppr_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DialogResult suppr = MessageBox.Show("Voulez-vous vraiment supprimer " + jeuChoisi.getNomJeux() + " ? ", "Choix", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (suppr == DialogResult.Yes)
            {
                db.deleteUnJeu(jeuChoisi.getIdJeux());
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            AjouterJeu view = new AjouterJeu();
            view.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            getData();
        }
    }
}