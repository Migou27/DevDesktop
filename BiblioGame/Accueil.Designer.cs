namespace BiblioGame
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lv_listeJeux = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tb_rechercheNom = new TextBox();
            pb_jeuAccueil = new PictureBox();
            btn_notation = new Button();
            tb_rechercheConsole = new TextBox();
            tb_rechercheEditeur = new TextBox();
            label1 = new Label();
            btn_suppr = new Button();
            btn_ajouter = new Button();
            btn_refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_jeuAccueil).BeginInit();
            SuspendLayout();
            // 
            // lv_listeJeux
            // 
            lv_listeJeux.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader1, columnHeader5 });
            lv_listeJeux.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lv_listeJeux.Location = new Point(28, 106);
            lv_listeJeux.MultiSelect = false;
            lv_listeJeux.Name = "lv_listeJeux";
            lv_listeJeux.Size = new Size(961, 418);
            lv_listeJeux.TabIndex = 0;
            lv_listeJeux.UseCompatibleStateImageBehavior = false;
            lv_listeJeux.View = View.Details;
            lv_listeJeux.ColumnClick += lv_listeJeux_ColumnClick;
            lv_listeJeux.SelectedIndexChanged += lv_listeJeux_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nom";
            columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Console";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date de sortie";
            columnHeader4.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Editeur";
            columnHeader1.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Moyenne";
            columnHeader5.Width = 100;
            // 
            // tb_rechercheNom
            // 
            tb_rechercheNom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_rechercheNom.Location = new Point(28, 556);
            tb_rechercheNom.Name = "tb_rechercheNom";
            tb_rechercheNom.PlaceholderText = "Rechercher Nom";
            tb_rechercheNom.Size = new Size(257, 27);
            tb_rechercheNom.TabIndex = 1;
            tb_rechercheNom.TextChanged += tb_recherche_TextChanged;
            // 
            // pb_jeuAccueil
            // 
            pb_jeuAccueil.BackgroundImageLayout = ImageLayout.Center;
            pb_jeuAccueil.Location = new Point(1080, 106);
            pb_jeuAccueil.Name = "pb_jeuAccueil";
            pb_jeuAccueil.Size = new Size(232, 278);
            pb_jeuAccueil.TabIndex = 4;
            pb_jeuAccueil.TabStop = false;
            // 
            // btn_notation
            // 
            btn_notation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_notation.ForeColor = SystemColors.ActiveCaptionText;
            btn_notation.Location = new Point(1123, 406);
            btn_notation.Name = "btn_notation";
            btn_notation.Size = new Size(146, 29);
            btn_notation.TabIndex = 5;
            btn_notation.Text = "Noter / Modifier";
            btn_notation.UseVisualStyleBackColor = true;
            btn_notation.Click += btn_notation_Click;
            // 
            // tb_rechercheConsole
            // 
            tb_rechercheConsole.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_rechercheConsole.Location = new Point(317, 556);
            tb_rechercheConsole.Name = "tb_rechercheConsole";
            tb_rechercheConsole.PlaceholderText = "Rechercher Console";
            tb_rechercheConsole.Size = new Size(220, 27);
            tb_rechercheConsole.TabIndex = 6;
            tb_rechercheConsole.TextChanged += tb_rechercheConsole_TextChanged;
            // 
            // tb_rechercheEditeur
            // 
            tb_rechercheEditeur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_rechercheEditeur.Location = new Point(560, 556);
            tb_rechercheEditeur.Name = "tb_rechercheEditeur";
            tb_rechercheEditeur.PlaceholderText = "Rechercher Editeur";
            tb_rechercheEditeur.Size = new Size(220, 27);
            tb_rechercheEditeur.TabIndex = 7;
            tb_rechercheEditeur.TextChanged += tb_recehercheEditeur_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Venus Rising", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(281, 37);
            label1.TabIndex = 8;
            label1.Text = "BiblioGame";
            // 
            // btn_suppr
            // 
            btn_suppr.BackColor = Color.OrangeRed;
            btn_suppr.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_suppr.Location = new Point(1144, 451);
            btn_suppr.Name = "btn_suppr";
            btn_suppr.Size = new Size(106, 29);
            btn_suppr.TabIndex = 9;
            btn_suppr.Text = "Supprimer";
            btn_suppr.UseVisualStyleBackColor = false;
            btn_suppr.Click += btn_suppr_Click;
            // 
            // btn_ajouter
            // 
            btn_ajouter.ForeColor = SystemColors.ActiveCaptionText;
            btn_ajouter.Location = new Point(873, 544);
            btn_ajouter.Name = "btn_ajouter";
            btn_ajouter.Size = new Size(116, 50);
            btn_ajouter.TabIndex = 11;
            btn_ajouter.Text = "Ajouter un jeu";
            btn_ajouter.UseVisualStyleBackColor = true;
            btn_ajouter.Click += btn_ajouter_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(873, 61);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(116, 29);
            btn_refresh.TabIndex = 12;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 671);
            Controls.Add(btn_refresh);
            Controls.Add(btn_ajouter);
            Controls.Add(btn_suppr);
            Controls.Add(label1);
            Controls.Add(tb_rechercheEditeur);
            Controls.Add(tb_rechercheConsole);
            Controls.Add(btn_notation);
            Controls.Add(pb_jeuAccueil);
            Controls.Add(tb_rechercheNom);
            Controls.Add(lv_listeJeux);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Accueil";
            Text = "Accueil";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_jeuAccueil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_listeJeux;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox tb_rechercheNom;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private PictureBox pb_jeuAccueil;
        private Button btn_notation;
        private TextBox tb_rechercheConsole;
        private TextBox tb_rechercheEditeur;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button btn_suppr;
        private Button btn_ajouter;
        private Button btn_refresh;
    }
}