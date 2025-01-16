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
    public partial class AjouterJeu : Form
    {
        public AjouterJeu()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            Jeu unJeu = new Jeu(0, tb_nom.Text, tb_console.Text, dtp_sortie.Value, tb_editeur.Text, tb_lien.Text, "0");
            List<int> lesNotes = new List<int>();
            lesNotes.Add((int)nud_histoire.Value);
            lesNotes.Add((int)nud_da.Value);
            lesNotes.Add((int)nud_musique.Value);
            lesNotes.Add((int)nud_vie.Value);
            lesNotes.Add((int)nud_gameplay.Value);
            lesNotes.Add((int)nud_diff.Value);
            lesNotes.Add((int)nud_rejoua.Value);

            Database db = new Database();
            db.ajouterUnJeu(unJeu, lesNotes);
        }
    }
}
