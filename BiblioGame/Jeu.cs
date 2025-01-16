using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BiblioGame
{
    public class Jeu
    {
        private int idJeux;
        private string nomJeux;
        private string consoleJeux;
        private DateTime sortieJeux;
        private string editeurJeux;
        private string imageJeux;
        private string moyenne;

        public Jeu(int idJeux, string nomJeux, string consoleJeux, DateTime sortieJeux, string editeurJeux, string imageJeux, string laMoyenne)
        {
            this.idJeux = idJeux;
            this.nomJeux = nomJeux;
            this.consoleJeux = consoleJeux;
            this.sortieJeux = sortieJeux;
            this.editeurJeux = editeurJeux;
            this.imageJeux = imageJeux;
            this.moyenne = laMoyenne;
        }

        public int getIdJeux() { return idJeux; }
        public string getNomJeux() { return nomJeux; }
        public string getConsoleJeux() {return consoleJeux; }
        public DateTime getSortieJeux() { return sortieJeux; }
        public string getEditeurJeux() { return editeurJeux;}
        public string getImageJeux() { return imageJeux; }
        public string getMoyenne() { return moyenne; }

        public void SetIdJeux(int idJeux)
        {
            this.idJeux = idJeux;
        }

        public void SetNomJeux(string nomJeux)
        {
            this.nomJeux = nomJeux;
        }

        public void SetConsoleJeux(string consoleJeux)
        {
            this.consoleJeux = consoleJeux;
        }

        public void SetSortieJeux(DateTime sortieJeux)
        {
            this.sortieJeux = sortieJeux;
        }

        public void SetEditeurJeux(string editeurJeux)
        {
            this.editeurJeux = editeurJeux;
        }

        public void SetImageJeux(string imageJeux)
        {
            this.imageJeux = imageJeux;
        }

        public void SetMoyenne(string moyenne)
        {
            this.moyenne = moyenne;
        }
    }
}
