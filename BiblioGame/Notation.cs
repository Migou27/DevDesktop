using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioGame
{
    public partial class Notation : Form
    {
        private Jeu leJeu;
        private List<int> notes = new List<int>();
        private Database db = new Database();
        public Notation(Jeu leJeu)
        {
            InitializeComponent();
            this.leJeu = leJeu;
            pb_jeuNotation.ImageLocation = leJeu.getImageJeux();
            pb_jeuNotation.SizeMode = PictureBoxSizeMode.StretchImage;

            lb_nom.Text += leJeu.getNomJeux();
            lb_console.Text += leJeu.getConsoleJeux();
            lb_editeur.Text += leJeu.getEditeurJeux();
            lb_date.Text += leJeu.getNomJeux().ToString();

            tb_nom.Text = leJeu.getNomJeux();
            tb_console.Text = leJeu.getConsoleJeux();
            tb_editeur.Text = leJeu.getEditeurJeux();
            dtp_sortie.Value = leJeu.getSortieJeux();
            tb_lien.Text = leJeu.getImageJeux();

        }

        private void Notation_Load(object sender, EventArgs e)
        {
            notes = db.getLesNotes("Select note from noter where idJeuxNoter = " + leJeu.getIdJeux().ToString());
            for (int i = 1; i <= notes.Count; i++)
            {
                changeNote(i, notes[i - 1]);
            }
            trb_histoire.Value = notes[0];
            trb_da.Value = notes[1];
            trb_musique.Value = notes[2];
            trb_vie.Value = notes[3];
            trb_gameplay.Value = notes[4];
            trb_difficulte.Value = notes[5];
            trb_rejoua.Value = notes[6];

            gb_updateInfo.Enabled = false;
            gb_updateInfo.Visible = false;
        }

        private void trb_histoire_Scroll(object sender, EventArgs e)
        {
            changeNote(1, trb_histoire.Value);
        }

        private void trb_da_Scroll(object sender, EventArgs e)
        {
            changeNote(2, trb_da.Value);
        }

        private void trb_musique_Scroll(object sender, EventArgs e)
        {
            changeNote(3, trb_musique.Value);
        }

        private void trb_vie_Scroll(object sender, EventArgs e)
        {
            changeNote(4, trb_vie.Value);
        }

        private void trb_gameplay_Scroll(object sender, EventArgs e)
        {
            changeNote(5, trb_gameplay.Value);
        }

        private void trb_difficulte_Scroll(object sender, EventArgs e)
        {
            changeNote(6, trb_difficulte.Value);
        }

        private void trb_rejoua_Scroll(object sender, EventArgs e)
        {
            changeNote(7, trb_rejoua.Value);
        }

        public void changeNote(int id, int laNote)
        {
            notes[id - 1] = laNote;
            switch (id)
            {
                case 1:
                    lb_noteHistoire.Text = laNote.ToString();
                    lb_noteHistoire.ForeColor = textColor(laNote);
                    break;

                case 2:
                    lb_noteDa.Text = laNote.ToString();
                    lb_noteDa.ForeColor = textColor(laNote);
                    break;

                case 3:
                    lb_noteMusique.Text = laNote.ToString();
                    lb_noteMusique.ForeColor = textColor(laNote);
                    break;

                case 4:
                    lb_noteVie.Text = laNote.ToString();
                    lb_noteVie.ForeColor = textColor(laNote);
                    break;

                case 5:
                    lb_noteGameplay.Text = laNote.ToString();
                    lb_noteGameplay.ForeColor = textColor(laNote);
                    break;

                case 6:
                    lb_noteDifficulte.Text = laNote.ToString();
                    lb_noteDifficulte.ForeColor = textColor(laNote);
                    break;

                case 7:
                    lb_noteRejoua.Text = laNote.ToString();
                    lb_noteRejoua.ForeColor = textColor(laNote);
                    break;
            }

        }

        public Color textColor(int note)
        {
            switch (note)
            {
                case 0: return Color.DarkRed;

                case 1: return Color.Red;

                case 2: return Color.Orange;

                case 3: return Color.Gold;

                case 4: return Color.Green;

                case 5: return Color.LimeGreen;
            }
            return Color.Black;

        }

        public void setLaModif()
        {
            gb_info.Enabled = !gb_info.Enabled;
            gb_info.Visible = !gb_info.Visible;

            gb_updateInfo.Enabled = !gb_updateInfo.Enabled;
            gb_updateInfo.Visible = !gb_updateInfo.Visible;

        }

        private void btn_validerNote_Click(object sender, EventArgs e)
        {
            try
            {
                Accueil accueil = new Accueil();
                float laMoyenne = 0;

                for (int i = 1; i <= notes.Count; i++)
                {
                    db.updateLaNote(notes[i - 1], leJeu.getIdJeux(), i);
                    laMoyenne += notes[i - 1];
                }
                MessageBox.Show("Insertion réussie");

            }
            catch
            {
                MessageBox.Show("Problème lors de l'insertion");
            }
        }

        private void btn_Accueil_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void pb_modifier_Click(object sender, EventArgs e)
        {
            setLaModif();
        }

        private void pb_annuler_Click(object sender, EventArgs e)
        {
            setLaModif();
        }

        private void pb_valider_Click(object sender, EventArgs e)
        {
            int id = leJeu.getIdJeux();

            if (tb_nom.Text != leJeu.getNomJeux())
            {
                db.updateLeNom(id, tb_nom.Text);
                leJeu.SetNomJeux(tb_nom.Text);
            }

            if (tb_console.Text != leJeu.getConsoleJeux())
            {
                db.updateLaConsole(id, tb_console.Text);
                leJeu.SetConsoleJeux(tb_console.Text);
            }

            if (tb_editeur.Text != leJeu.getEditeurJeux())
            {
                db.updateLediteur(id, tb_editeur.Text);
                leJeu.SetEditeurJeux(tb_editeur.Text);
            }

            if (dtp_sortie.Value != leJeu.getSortieJeux())
            {
                db.updateLaDate(id, dtp_sortie.Value.ToString("yyyy-MM-dd"));
                leJeu.SetSortieJeux(dtp_sortie.Value);
            }

            if (tb_lien.Text != leJeu.getImageJeux())
            {
                db.updateLajaquette(id, tb_lien.Text);
                leJeu.SetImageJeux(tb_lien.Text);
            }

            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }
    }
}
