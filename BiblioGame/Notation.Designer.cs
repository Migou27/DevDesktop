namespace BiblioGame
{
    partial class Notation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notation));
            pb_jeuNotation = new PictureBox();
            gb_info = new GroupBox();
            pb_modifier = new PictureBox();
            lb_editeur = new Label();
            lb_date = new Label();
            lb_console = new Label();
            lb_nom = new Label();
            gb_updateInfo = new GroupBox();
            tb_lien = new TextBox();
            label12 = new Label();
            pb_annuler = new PictureBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tb_nom = new TextBox();
            pb_valider = new PictureBox();
            dtp_sortie = new DateTimePicker();
            tb_console = new TextBox();
            tb_editeur = new TextBox();
            gb_notation = new GroupBox();
            btn_validerNote = new Button();
            lb_noteVie = new Label();
            lb_noteGameplay = new Label();
            lb_noteDifficulte = new Label();
            lb_noteRejoua = new Label();
            lb_noteMusique = new Label();
            lb_noteDa = new Label();
            lb_noteHistoire = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            trb_rejoua = new TrackBar();
            trb_difficulte = new TrackBar();
            trb_gameplay = new TrackBar();
            trb_vie = new TrackBar();
            trb_musique = new TrackBar();
            trb_da = new TrackBar();
            label2 = new Label();
            label1 = new Label();
            trb_histoire = new TrackBar();
            btn_Accueil = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_jeuNotation).BeginInit();
            gb_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_modifier).BeginInit();
            gb_updateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_annuler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_valider).BeginInit();
            gb_notation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trb_rejoua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_difficulte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_gameplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_vie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_musique).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_da).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trb_histoire).BeginInit();
            SuspendLayout();
            // 
            // pb_jeuNotation
            // 
            pb_jeuNotation.Location = new Point(101, 68);
            pb_jeuNotation.Name = "pb_jeuNotation";
            pb_jeuNotation.Size = new Size(227, 315);
            pb_jeuNotation.TabIndex = 0;
            pb_jeuNotation.TabStop = false;
            // 
            // gb_info
            // 
            gb_info.Controls.Add(pb_modifier);
            gb_info.Controls.Add(lb_editeur);
            gb_info.Controls.Add(lb_date);
            gb_info.Controls.Add(lb_console);
            gb_info.Controls.Add(lb_nom);
            gb_info.Location = new Point(12, 400);
            gb_info.Name = "gb_info";
            gb_info.Size = new Size(421, 231);
            gb_info.TabIndex = 1;
            gb_info.TabStop = false;
            gb_info.Text = "Informations";
            // 
            // pb_modifier
            // 
            pb_modifier.Image = (Image)resources.GetObject("pb_modifier.Image");
            pb_modifier.Location = new Point(378, 11);
            pb_modifier.Name = "pb_modifier";
            pb_modifier.Size = new Size(37, 36);
            pb_modifier.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_modifier.TabIndex = 4;
            pb_modifier.TabStop = false;
            pb_modifier.Click += pb_modifier_Click;
            // 
            // lb_editeur
            // 
            lb_editeur.AutoSize = true;
            lb_editeur.Location = new Point(6, 122);
            lb_editeur.Name = "lb_editeur";
            lb_editeur.Size = new Size(67, 20);
            lb_editeur.TabIndex = 3;
            lb_editeur.Text = "Editeur : ";
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(6, 157);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(114, 20);
            lb_date.TabIndex = 2;
            lb_date.Text = "Date de sortie : ";
            // 
            // lb_console
            // 
            lb_console.AutoSize = true;
            lb_console.Location = new Point(6, 86);
            lb_console.Name = "lb_console";
            lb_console.Size = new Size(73, 20);
            lb_console.TabIndex = 1;
            lb_console.Text = "Console : ";
            // 
            // lb_nom
            // 
            lb_nom.AutoSize = true;
            lb_nom.Location = new Point(6, 47);
            lb_nom.Name = "lb_nom";
            lb_nom.Size = new Size(98, 20);
            lb_nom.TabIndex = 0;
            lb_nom.Text = "Nom du jeu : ";
            // 
            // gb_updateInfo
            // 
            gb_updateInfo.Controls.Add(tb_lien);
            gb_updateInfo.Controls.Add(label12);
            gb_updateInfo.Controls.Add(pb_annuler);
            gb_updateInfo.Controls.Add(label11);
            gb_updateInfo.Controls.Add(label10);
            gb_updateInfo.Controls.Add(label9);
            gb_updateInfo.Controls.Add(label8);
            gb_updateInfo.Controls.Add(tb_nom);
            gb_updateInfo.Controls.Add(pb_valider);
            gb_updateInfo.Controls.Add(dtp_sortie);
            gb_updateInfo.Controls.Add(tb_console);
            gb_updateInfo.Controls.Add(tb_editeur);
            gb_updateInfo.Location = new Point(12, 411);
            gb_updateInfo.Name = "gb_updateInfo";
            gb_updateInfo.Size = new Size(446, 220);
            gb_updateInfo.TabIndex = 10;
            gb_updateInfo.TabStop = false;
            gb_updateInfo.Text = "Mise à jour des informations";
            // 
            // tb_lien
            // 
            tb_lien.Location = new Point(106, 181);
            tb_lien.Name = "tb_lien";
            tb_lien.Size = new Size(257, 27);
            tb_lien.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 184);
            label12.Name = "label12";
            label12.Size = new Size(89, 20);
            label12.TabIndex = 12;
            label12.Text = "Lien Image :";
            // 
            // pb_annuler
            // 
            pb_annuler.BackgroundImageLayout = ImageLayout.None;
            pb_annuler.Image = (Image)resources.GetObject("pb_annuler.Image");
            pb_annuler.Location = new Point(397, 15);
            pb_annuler.Name = "pb_annuler";
            pb_annuler.Size = new Size(43, 42);
            pb_annuler.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_annuler.TabIndex = 11;
            pb_annuler.TabStop = false;
            pb_annuler.Click += pb_annuler_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 151);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 5;
            label11.Text = "Sortie :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 112);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 5;
            label10.Text = "Editeur :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 77);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 5;
            label9.Text = "Console :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 37);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 5;
            label8.Text = "Nom du jeu :";
            // 
            // tb_nom
            // 
            tb_nom.Location = new Point(106, 37);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(257, 27);
            tb_nom.TabIndex = 6;
            // 
            // pb_valider
            // 
            pb_valider.Image = (Image)resources.GetObject("pb_valider.Image");
            pb_valider.Location = new Point(397, 173);
            pb_valider.Name = "pb_valider";
            pb_valider.Size = new Size(43, 41);
            pb_valider.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_valider.TabIndex = 5;
            pb_valider.TabStop = false;
            pb_valider.Click += pb_valider_Click;
            // 
            // dtp_sortie
            // 
            dtp_sortie.Location = new Point(106, 146);
            dtp_sortie.Name = "dtp_sortie";
            dtp_sortie.Size = new Size(257, 27);
            dtp_sortie.TabIndex = 9;
            // 
            // tb_console
            // 
            tb_console.Location = new Point(106, 74);
            tb_console.Name = "tb_console";
            tb_console.Size = new Size(257, 27);
            tb_console.TabIndex = 7;
            // 
            // tb_editeur
            // 
            tb_editeur.Location = new Point(106, 109);
            tb_editeur.Name = "tb_editeur";
            tb_editeur.Size = new Size(257, 27);
            tb_editeur.TabIndex = 8;
            // 
            // gb_notation
            // 
            gb_notation.Controls.Add(btn_validerNote);
            gb_notation.Controls.Add(lb_noteVie);
            gb_notation.Controls.Add(lb_noteGameplay);
            gb_notation.Controls.Add(lb_noteDifficulte);
            gb_notation.Controls.Add(lb_noteRejoua);
            gb_notation.Controls.Add(lb_noteMusique);
            gb_notation.Controls.Add(lb_noteDa);
            gb_notation.Controls.Add(lb_noteHistoire);
            gb_notation.Controls.Add(label7);
            gb_notation.Controls.Add(label6);
            gb_notation.Controls.Add(label5);
            gb_notation.Controls.Add(label4);
            gb_notation.Controls.Add(label3);
            gb_notation.Controls.Add(trb_rejoua);
            gb_notation.Controls.Add(trb_difficulte);
            gb_notation.Controls.Add(trb_gameplay);
            gb_notation.Controls.Add(trb_vie);
            gb_notation.Controls.Add(trb_musique);
            gb_notation.Controls.Add(trb_da);
            gb_notation.Controls.Add(label2);
            gb_notation.Controls.Add(label1);
            gb_notation.Controls.Add(trb_histoire);
            gb_notation.Location = new Point(467, 12);
            gb_notation.Name = "gb_notation";
            gb_notation.Size = new Size(434, 625);
            gb_notation.TabIndex = 2;
            gb_notation.TabStop = false;
            gb_notation.Text = "Notation";
            // 
            // btn_validerNote
            // 
            btn_validerNote.BackColor = Color.LawnGreen;
            btn_validerNote.Location = new Point(334, 590);
            btn_validerNote.Name = "btn_validerNote";
            btn_validerNote.Size = new Size(94, 29);
            btn_validerNote.TabIndex = 21;
            btn_validerNote.Text = "Valider";
            btn_validerNote.UseVisualStyleBackColor = false;
            btn_validerNote.Click += btn_validerNote_Click;
            // 
            // lb_noteVie
            // 
            lb_noteVie.AutoSize = true;
            lb_noteVie.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteVie.Location = new Point(366, 253);
            lb_noteVie.Name = "lb_noteVie";
            lb_noteVie.Size = new Size(24, 28);
            lb_noteVie.TabIndex = 20;
            lb_noteVie.Text = "0";
            // 
            // lb_noteGameplay
            // 
            lb_noteGameplay.AutoSize = true;
            lb_noteGameplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteGameplay.Location = new Point(367, 322);
            lb_noteGameplay.Name = "lb_noteGameplay";
            lb_noteGameplay.Size = new Size(24, 28);
            lb_noteGameplay.TabIndex = 19;
            lb_noteGameplay.Text = "0";
            // 
            // lb_noteDifficulte
            // 
            lb_noteDifficulte.AutoSize = true;
            lb_noteDifficulte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteDifficulte.Location = new Point(366, 394);
            lb_noteDifficulte.Name = "lb_noteDifficulte";
            lb_noteDifficulte.Size = new Size(24, 28);
            lb_noteDifficulte.TabIndex = 18;
            lb_noteDifficulte.Text = "0";
            // 
            // lb_noteRejoua
            // 
            lb_noteRejoua.AutoSize = true;
            lb_noteRejoua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteRejoua.Location = new Point(366, 466);
            lb_noteRejoua.Name = "lb_noteRejoua";
            lb_noteRejoua.Size = new Size(24, 28);
            lb_noteRejoua.TabIndex = 17;
            lb_noteRejoua.Text = "0";
            // 
            // lb_noteMusique
            // 
            lb_noteMusique.AutoSize = true;
            lb_noteMusique.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteMusique.Location = new Point(366, 176);
            lb_noteMusique.Name = "lb_noteMusique";
            lb_noteMusique.Size = new Size(24, 28);
            lb_noteMusique.TabIndex = 16;
            lb_noteMusique.Text = "0";
            // 
            // lb_noteDa
            // 
            lb_noteDa.AutoSize = true;
            lb_noteDa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteDa.Location = new Point(366, 100);
            lb_noteDa.Name = "lb_noteDa";
            lb_noteDa.Size = new Size(24, 28);
            lb_noteDa.TabIndex = 15;
            lb_noteDa.Text = "0";
            // 
            // lb_noteHistoire
            // 
            lb_noteHistoire.AutoSize = true;
            lb_noteHistoire.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_noteHistoire.Location = new Point(367, 37);
            lb_noteHistoire.Name = "lb_noteHistoire";
            lb_noteHistoire.Size = new Size(24, 28);
            lb_noteHistoire.TabIndex = 14;
            lb_noteHistoire.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 470);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 13;
            label7.Text = "Rejouabilité : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 399);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 12;
            label6.Text = "Difficulté : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 326);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 11;
            label5.Text = "Gameplay : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 255);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 10;
            label4.Text = "Durée de vie : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 179);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 9;
            label3.Text = "Musique : ";
            // 
            // trb_rejoua
            // 
            trb_rejoua.Location = new Point(126, 470);
            trb_rejoua.Maximum = 5;
            trb_rejoua.Name = "trb_rejoua";
            trb_rejoua.Size = new Size(217, 56);
            trb_rejoua.TabIndex = 8;
            trb_rejoua.Scroll += trb_rejoua_Scroll;
            // 
            // trb_difficulte
            // 
            trb_difficulte.Location = new Point(126, 399);
            trb_difficulte.Maximum = 5;
            trb_difficulte.Name = "trb_difficulte";
            trb_difficulte.Size = new Size(217, 56);
            trb_difficulte.TabIndex = 7;
            trb_difficulte.Scroll += trb_difficulte_Scroll;
            // 
            // trb_gameplay
            // 
            trb_gameplay.Location = new Point(126, 326);
            trb_gameplay.Maximum = 5;
            trb_gameplay.Name = "trb_gameplay";
            trb_gameplay.Size = new Size(217, 56);
            trb_gameplay.TabIndex = 6;
            trb_gameplay.Scroll += trb_gameplay_Scroll;
            // 
            // trb_vie
            // 
            trb_vie.Location = new Point(126, 255);
            trb_vie.Maximum = 5;
            trb_vie.Name = "trb_vie";
            trb_vie.Size = new Size(217, 56);
            trb_vie.TabIndex = 5;
            trb_vie.Scroll += trb_vie_Scroll;
            // 
            // trb_musique
            // 
            trb_musique.Location = new Point(127, 179);
            trb_musique.Maximum = 5;
            trb_musique.Name = "trb_musique";
            trb_musique.Size = new Size(217, 56);
            trb_musique.TabIndex = 4;
            trb_musique.Scroll += trb_musique_Scroll;
            // 
            // trb_da
            // 
            trb_da.Location = new Point(128, 102);
            trb_da.Maximum = 5;
            trb_da.Name = "trb_da";
            trb_da.Size = new Size(217, 56);
            trb_da.TabIndex = 3;
            trb_da.Scroll += trb_da_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 102);
            label2.Name = "label2";
            label2.Size = new Size(82, 40);
            label2.TabIndex = 2;
            label2.Text = "Direction\r\nartistique : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Histoire : ";
            // 
            // trb_histoire
            // 
            trb_histoire.Location = new Point(128, 40);
            trb_histoire.Maximum = 5;
            trb_histoire.Name = "trb_histoire";
            trb_histoire.Size = new Size(217, 56);
            trb_histoire.TabIndex = 0;
            trb_histoire.Scroll += trb_histoire_Scroll;
            // 
            // btn_Accueil
            // 
            btn_Accueil.Location = new Point(12, 12);
            btn_Accueil.Name = "btn_Accueil";
            btn_Accueil.Size = new Size(75, 28);
            btn_Accueil.TabIndex = 3;
            btn_Accueil.Text = "Accueil";
            btn_Accueil.UseVisualStyleBackColor = true;
            btn_Accueil.Click += btn_Accueil_Click;
            // 
            // Notation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 662);
            Controls.Add(gb_updateInfo);
            Controls.Add(btn_Accueil);
            Controls.Add(gb_notation);
            Controls.Add(gb_info);
            Controls.Add(pb_jeuNotation);
            Name = "Notation";
            Text = "Notation";
            Load += Notation_Load;
            ((System.ComponentModel.ISupportInitialize)pb_jeuNotation).EndInit();
            gb_info.ResumeLayout(false);
            gb_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_modifier).EndInit();
            gb_updateInfo.ResumeLayout(false);
            gb_updateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_annuler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_valider).EndInit();
            gb_notation.ResumeLayout(false);
            gb_notation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trb_rejoua).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_difficulte).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_gameplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_vie).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_musique).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_da).EndInit();
            ((System.ComponentModel.ISupportInitialize)trb_histoire).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_jeuNotation;
        private GroupBox gb_info;
        private Label lb_editeur;
        private Label lb_date;
        private Label lb_console;
        private Label lb_nom;
        private GroupBox gb_notation;
        private Label label2;
        private Label label1;
        private TrackBar trb_histoire;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TrackBar trb_rejoua;
        private TrackBar trb_difficulte;
        private TrackBar trb_gameplay;
        private TrackBar trb_vie;
        private TrackBar trb_musique;
        private TrackBar trb_da;
        private Label lb_noteVie;
        private Label lb_noteGameplay;
        private Label lb_noteDifficulte;
        private Label lb_noteRejoua;
        private Label lb_noteMusique;
        private Label lb_noteDa;
        private Label lb_noteHistoire;
        private Button btn_validerNote;
        private Button btn_Accueil;
        private PictureBox pb_modifier;
        private PictureBox pb_valider;
        private DateTimePicker dtp_sortie;
        private TextBox tb_editeur;
        private TextBox tb_console;
        private TextBox tb_nom;
        private GroupBox gb_updateInfo;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox pb_annuler;
        private TextBox tb_lien;
        private Label label12;
        private Button button1;
    }
}