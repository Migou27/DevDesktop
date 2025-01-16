namespace BiblioGame
{
    partial class AjouterJeu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            tb_nom = new TextBox();
            tb_console = new TextBox();
            tb_editeur = new TextBox();
            tb_lien = new TextBox();
            dtp_sortie = new DateTimePicker();
            nud_histoire = new NumericUpDown();
            nud_da = new NumericUpDown();
            nud_musique = new NumericUpDown();
            nud_vie = new NumericUpDown();
            nud_gameplay = new NumericUpDown();
            nud_diff = new NumericUpDown();
            nud_rejoua = new NumericUpDown();
            btn_valider = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_histoire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_da).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_musique).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_vie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_gameplay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_diff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_rejoua).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Console :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Date de sortie :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Editeur :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 4;
            label5.Text = "Lien jaquette :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 235);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 5;
            label6.Text = "Histoire :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 279);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 6;
            label7.Text = "Direction artistique :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 328);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Musique :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 380);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 8;
            label9.Text = "Durée de vie :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 430);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 9;
            label10.Text = "Gameplay :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 481);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 10;
            label11.Text = "Difficulté :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 531);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 11;
            label12.Text = "Rejouabilité :";
            // 
            // tb_nom
            // 
            tb_nom.Location = new Point(145, 19);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(196, 27);
            tb_nom.TabIndex = 12;
            // 
            // tb_console
            // 
            tb_console.Location = new Point(145, 62);
            tb_console.Name = "tb_console";
            tb_console.Size = new Size(196, 27);
            tb_console.TabIndex = 13;
            // 
            // tb_editeur
            // 
            tb_editeur.Location = new Point(145, 140);
            tb_editeur.Name = "tb_editeur";
            tb_editeur.Size = new Size(196, 27);
            tb_editeur.TabIndex = 15;
            // 
            // tb_lien
            // 
            tb_lien.Location = new Point(145, 185);
            tb_lien.Name = "tb_lien";
            tb_lien.Size = new Size(196, 27);
            tb_lien.TabIndex = 16;
            // 
            // dtp_sortie
            // 
            dtp_sortie.CustomFormat = "yyyy-mm-dd";
            dtp_sortie.Location = new Point(145, 97);
            dtp_sortie.Name = "dtp_sortie";
            dtp_sortie.Size = new Size(250, 27);
            dtp_sortie.TabIndex = 17;
            // 
            // nud_histoire
            // 
            nud_histoire.Location = new Point(191, 228);
            nud_histoire.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_histoire.Name = "nud_histoire";
            nud_histoire.Size = new Size(150, 27);
            nud_histoire.TabIndex = 18;
            // 
            // nud_da
            // 
            nud_da.Location = new Point(191, 277);
            nud_da.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_da.Name = "nud_da";
            nud_da.Size = new Size(150, 27);
            nud_da.TabIndex = 19;
            // 
            // nud_musique
            // 
            nud_musique.Location = new Point(191, 326);
            nud_musique.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_musique.Name = "nud_musique";
            nud_musique.Size = new Size(150, 27);
            nud_musique.TabIndex = 20;
            // 
            // nud_vie
            // 
            nud_vie.Location = new Point(191, 378);
            nud_vie.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_vie.Name = "nud_vie";
            nud_vie.Size = new Size(150, 27);
            nud_vie.TabIndex = 21;
            // 
            // nud_gameplay
            // 
            nud_gameplay.Location = new Point(191, 428);
            nud_gameplay.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_gameplay.Name = "nud_gameplay";
            nud_gameplay.Size = new Size(150, 27);
            nud_gameplay.TabIndex = 22;
            // 
            // nud_diff
            // 
            nud_diff.Location = new Point(191, 479);
            nud_diff.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_diff.Name = "nud_diff";
            nud_diff.Size = new Size(150, 27);
            nud_diff.TabIndex = 23;
            // 
            // nud_rejoua
            // 
            nud_rejoua.Location = new Point(191, 529);
            nud_rejoua.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_rejoua.Name = "nud_rejoua";
            nud_rejoua.Size = new Size(150, 27);
            nud_rejoua.TabIndex = 24;
            // 
            // btn_valider
            // 
            btn_valider.Location = new Point(304, 574);
            btn_valider.Name = "btn_valider";
            btn_valider.Size = new Size(94, 29);
            btn_valider.TabIndex = 25;
            btn_valider.Text = "Valider";
            btn_valider.UseVisualStyleBackColor = true;
            btn_valider.Click += btn_valider_Click;
            // 
            // AjouterJeu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 610);
            Controls.Add(btn_valider);
            Controls.Add(nud_rejoua);
            Controls.Add(nud_diff);
            Controls.Add(nud_gameplay);
            Controls.Add(nud_vie);
            Controls.Add(nud_musique);
            Controls.Add(nud_da);
            Controls.Add(nud_histoire);
            Controls.Add(dtp_sortie);
            Controls.Add(tb_lien);
            Controls.Add(tb_editeur);
            Controls.Add(tb_console);
            Controls.Add(tb_nom);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjouterJeu";
            Text = "AjouterJeu";
            ((System.ComponentModel.ISupportInitialize)nud_histoire).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_da).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_musique).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_vie).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_gameplay).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_diff).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_rejoua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox tb_nom;
        private TextBox tb_console;
        private TextBox tb_editeur;
        private TextBox tb_lien;
        private DateTimePicker dtp_sortie;
        private NumericUpDown nud_histoire;
        private NumericUpDown nud_da;
        private NumericUpDown nud_musique;
        private NumericUpDown nud_vie;
        private NumericUpDown nud_gameplay;
        private NumericUpDown nud_diff;
        private NumericUpDown nud_rejoua;
        private Button btn_valider;
    }
}