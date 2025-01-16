using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioGame
{
    internal class Database
    {
        private SQLiteConnection connexion;

        //private string path = "Data source=D:/YNOV_2024-2025/DesktopWinForm/BiblioGame/BiblioGame.db";

        static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        static string relativePath = Path.Combine(basePath, "", "BiblioGame.db");
        string path = "Data source=" + Path.GetFullPath(relativePath);

        public List<Jeu> getLesJeux(string sql) 
        {
            this.connexion = new SQLiteConnection(path);
            DataTable dt = new DataTable();
            List<Jeu> data = new List<Jeu>();
            try
            {
                connexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connexion);
                adapter.Fill(dt);

                foreach(DataRow unJeu in dt.Rows)
                {
                    int idJeux = int.Parse(unJeu["idJeux"].ToString());
                    string nomJeux = unJeu["nomJeux"].ToString();
                    string consoleJeux = unJeu["consoleJeux"].ToString();
                    DateTime sortieJeux = DateTime.Parse(unJeu["sortieJeux"].ToString());
                    string editeurJeux = unJeu["editeurJeux"].ToString();
                    string imageJeux = unJeu["imageJeux"].ToString() ;
                    string moyenne = unJeu["Moyenne"].ToString();

                    data.Add(new Jeu(idJeux, nomJeux, consoleJeux, sortieJeux, editeurJeux, imageJeux, moyenne));
                }
                connexion.Close();

                return data;
            }
            catch
            {
                return data;
            }
        }

        public List<int> getLesNotes(string sql)
        {
            this.connexion = new SQLiteConnection(path);
            DataTable dt = new DataTable();
            List<int> data = new List<int>();

            try
            {
                connexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connexion);
                adapter.Fill(dt);

                foreach (DataRow uneNote in dt.Rows)
                {
                    data.Add(int.Parse(uneNote["note"].ToString()));
                }
                connexion.Close();

                return data;
            }
            catch
            {
                return data;
            }
        }

        public void updateLeNom(int idJeu, string leNom)
        {
            this.connexion = new SQLiteConnection(path);
            string sql = "UPDATE jeux SET nomJeux = @nom WHERE idJeux = @id";

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@nom", leNom);
                        command.Parameters.AddWithValue("@id", idJeu);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }

        }

        public void updateLaConsole(int idJeu, string laConsole)
        {
            this.connexion = new SQLiteConnection(path);
            string sql = "UPDATE jeux SET consoleJeux = @console WHERE idJeux = @id";

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@console", laConsole);
                        command.Parameters.AddWithValue("@id", idJeu);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        public void updateLediteur(int idJeu, string lEditeur)
        {
            this.connexion = new SQLiteConnection(path);
            string sql = "UPDATE jeux SET editeurJeux = @editeur WHERE idJeux = @id";

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@editeur", lEditeur);
                        command.Parameters.AddWithValue("@id", idJeu);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        public void updateLaDate(int idJeu, string laDate)
        {
            this.connexion = new SQLiteConnection(path);
            string sql = "UPDATE jeux SET sortieJeux = @sortie WHERE idJeux = @id";

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@sortie", laDate);
                        command.Parameters.AddWithValue("@id", idJeu);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        public void updateLajaquette(int idJeu, string leLien)
        {
            this.connexion = new SQLiteConnection(path);
            string sql = "UPDATE jeux SET imageJeux = @image WHERE idJeux = @id";

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@image", leLien);
                        command.Parameters.AddWithValue("@id", idJeu);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        public void updateLaNote(int note, int idJeux, int idNota)
        {
            string sql = "UPDATE noter SET note = @note WHERE idJeuxNoter = @idJeux AND idNotationNoter = @idNota";
            this.connexion = new SQLiteConnection(path);

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql, connexion))
                    {
                        command.Parameters.AddWithValue("@note", note);
                        command.Parameters.AddWithValue("@idJeux", idJeux);
                        command.Parameters.AddWithValue("@idNota", idNota);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
        }

        public void deleteUnJeu(int idJeux)
        {
            string sql1 = "DELETE FROM noter WHERE idJeuxNoter = @idJeuxNoter";
            string sql2 = "DELETE FROM jeux WHERE idJeux = @idJeux";
            this.connexion = new SQLiteConnection(path);

            try
            {
                using (connexion)
                {
                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql1, connexion))
                    {
                        command.Parameters.AddWithValue("@idJeuxNoter", idJeux);

                        command.ExecuteNonQuery();
                    }

                    using (SQLiteCommand command = new SQLiteCommand(sql2, connexion))
                    {
                        command.Parameters.AddWithValue("@idJeux", idJeux);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();

                }
                MessageBox.Show("Jeu supprimé");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression");
            }
        }

        public void ajouterUnJeu(Jeu unJeu, List<int> lesNotes)
        {
            string sql1 = "INSERT INTO jeux (idJeux, nomJeux, consoleJeux, sortieJeux, editeurJeux, imageJeux) "
                + "values (@newId, @nomJeux, @consoleJeux, @sortieJeux, @editeurJeux, @imageJeux)";
            string sql2 = "SELECT MAX(idJeux) FROM jeux";
            string sql3 = "INSERT INTO noter (idJeuxNoter, idNotationNoter, note) "
                + "values (@idJeux, 1, @note1), "
                + "(@idJeux, 2, @note2), "
                + "(@idJeux, 3, @note3), "
                + "(@idJeux, 4, @note4), "
                + "(@idJeux, 5, @note5), "
                + "(@idJeux, 6, @note6), "
                + "(@idJeux, 7, @note7)";

            this.connexion = new SQLiteConnection(path);
            int newId = 0;

            try
            {
                using (connexion)
                {

                    connexion.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sql2, connexion))
                    {
                        object result = command.ExecuteScalar();
                        newId = Convert.ToInt32(result)+1;
                    }


                    using (SQLiteCommand command = new SQLiteCommand(sql1, connexion))
                    {
                        command.Parameters.AddWithValue("@newId", newId);
                        command.Parameters.AddWithValue("@nomJeux", unJeu.getNomJeux());
                        command.Parameters.AddWithValue("@consoleJeux", unJeu.getConsoleJeux());
                        command.Parameters.AddWithValue("@sortieJeux", unJeu.getSortieJeux().ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@editeurJeux", unJeu.getEditeurJeux());
                        command.Parameters.AddWithValue("@imageJeux", unJeu.getImageJeux());

                        command.ExecuteNonQuery();
                    }

                    using (SQLiteCommand command = new SQLiteCommand(sql3, connexion))
                    {
                        command.Parameters.AddWithValue("@idJeux", newId);
                        command.Parameters.AddWithValue("@note1", lesNotes[0]);
                        command.Parameters.AddWithValue("@note2", lesNotes[1]);
                        command.Parameters.AddWithValue("@note3", lesNotes[2]);
                        command.Parameters.AddWithValue("@note4", lesNotes[3]);
                        command.Parameters.AddWithValue("@note5", lesNotes[4]);
                        command.Parameters.AddWithValue("@note6", lesNotes[5]);
                        command.Parameters.AddWithValue("@note7", lesNotes[6]);

                        command.ExecuteNonQuery();
                    }

                    connexion.Close();

                }
                MessageBox.Show("Jeu ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout'");
            }
        }
    }
}
