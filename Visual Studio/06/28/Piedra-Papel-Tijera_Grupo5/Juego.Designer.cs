namespace Piedra_Papel_Tijera_Grupo5
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            lblWel = new Label();
            lblRound = new Label();
            rbPiedra = new RadioButton();
            rbPapel = new RadioButton();
            rbTijera = new RadioButton();
            btnJugar = new Button();
            lblRes = new Label();
            btnNext = new Button();
            btnFin = new Button();
            lblGan = new Label();
            lblPer = new Label();
            lblEm = new Label();
            lblFin = new Label();
            btnRank = new Button();
            SuspendLayout();
            // 
            // lblWel
            // 
            lblWel.BackColor = Color.Transparent;
            lblWel.FlatStyle = FlatStyle.Flat;
            lblWel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblWel.ForeColor = Color.White;
            lblWel.Location = new Point(-12, -7);
            lblWel.Name = "lblWel";
            lblWel.Size = new Size(820, 50);
            lblWel.TabIndex = 0;
            lblWel.Text = "Bienvenido Jugador";
            lblWel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            lblRound.BackColor = Color.Transparent;
            lblRound.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRound.ForeColor = Color.White;
            lblRound.Location = new Point(-12, 43);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(820, 41);
            lblRound.TabIndex = 1;
            lblRound.Text = "Ronda N° 1";
            lblRound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbPiedra
            // 
            rbPiedra.Appearance = Appearance.Button;
            rbPiedra.BackgroundImage = (Image)resources.GetObject("rbPiedra.BackgroundImage");
            rbPiedra.BackgroundImageLayout = ImageLayout.Zoom;
            rbPiedra.CheckAlign = ContentAlignment.BottomLeft;
            rbPiedra.ForeColor = SystemColors.ActiveCaptionText;
            rbPiedra.Location = new Point(145, 122);
            rbPiedra.Name = "rbPiedra";
            rbPiedra.Size = new Size(150, 150);
            rbPiedra.TabIndex = 3;
            rbPiedra.TabStop = true;
            rbPiedra.TextAlign = ContentAlignment.BottomCenter;
            rbPiedra.UseVisualStyleBackColor = true;
            // 
            // rbPapel
            // 
            rbPapel.Appearance = Appearance.Button;
            rbPapel.BackColor = SystemColors.Control;
            rbPapel.BackgroundImage = (Image)resources.GetObject("rbPapel.BackgroundImage");
            rbPapel.BackgroundImageLayout = ImageLayout.Zoom;
            rbPapel.CheckAlign = ContentAlignment.BottomLeft;
            rbPapel.ForeColor = SystemColors.ActiveCaptionText;
            rbPapel.Location = new Point(324, 122);
            rbPapel.Name = "rbPapel";
            rbPapel.Size = new Size(150, 150);
            rbPapel.TabIndex = 5;
            rbPapel.TabStop = true;
            rbPapel.TextAlign = ContentAlignment.BottomCenter;
            rbPapel.UseVisualStyleBackColor = true;
            // 
            // rbTijera
            // 
            rbTijera.Appearance = Appearance.Button;
            rbTijera.BackColor = SystemColors.Control;
            rbTijera.BackgroundImage = (Image)resources.GetObject("rbTijera.BackgroundImage");
            rbTijera.BackgroundImageLayout = ImageLayout.Zoom;
            rbTijera.CheckAlign = ContentAlignment.BottomLeft;
            rbTijera.ForeColor = SystemColors.ActiveCaptionText;
            rbTijera.Location = new Point(501, 122);
            rbTijera.Name = "rbTijera";
            rbTijera.Size = new Size(150, 150);
            rbTijera.TabIndex = 6;
            rbTijera.TabStop = true;
            rbTijera.TextAlign = ContentAlignment.BottomCenter;
            rbTijera.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = SystemColors.HotTrack;
            btnJugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugar.ForeColor = SystemColors.InactiveBorder;
            btnJugar.Location = new Point(324, 288);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(150, 47);
            btnJugar.TabIndex = 7;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // lblRes
            // 
            lblRes.BackColor = Color.White;
            lblRes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRes.Location = new Point(-12, 338);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(820, 53);
            lblRes.TabIndex = 8;
            lblRes.Text = "GANASTE";
            lblRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.CornflowerBlue;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.InactiveBorder;
            btnNext.Location = new Point(324, 288);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 47);
            btnNext.TabIndex = 9;
            btnNext.Text = "SIGUIENTE";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnFin
            // 
            btnFin.BackColor = Color.Navy;
            btnFin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFin.ForeColor = SystemColors.InactiveBorder;
            btnFin.Location = new Point(324, 288);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(150, 47);
            btnFin.TabIndex = 10;
            btnFin.Text = "FINALIZAR";
            btnFin.UseVisualStyleBackColor = false;
            btnFin.Click += btnFin_Click;
            // 
            // lblGan
            // 
            lblGan.AutoSize = true;
            lblGan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGan.ForeColor = Color.Green;
            lblGan.Location = new Point(322, 84);
            lblGan.Name = "lblGan";
            lblGan.Size = new Size(49, 28);
            lblGan.TabIndex = 11;
            lblGan.Text = "G: 0";
            // 
            // lblPer
            // 
            lblPer.AutoSize = true;
            lblPer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPer.ForeColor = Color.Red;
            lblPer.Location = new Point(377, 84);
            lblPer.Name = "lblPer";
            lblPer.Size = new Size(47, 28);
            lblPer.TabIndex = 12;
            lblPer.Text = "P: 0";
            // 
            // lblEm
            // 
            lblEm.AutoSize = true;
            lblEm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEm.ForeColor = Color.DodgerBlue;
            lblEm.Location = new Point(430, 84);
            lblEm.Name = "lblEm";
            lblEm.Size = new Size(46, 28);
            lblEm.TabIndex = 13;
            lblEm.Text = "E: 0";
            // 
            // lblFin
            // 
            lblFin.BackColor = Color.White;
            lblFin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblFin.Location = new Point(145, 149);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(506, 94);
            lblFin.TabIndex = 14;
            lblFin.Text = "label1";
            lblFin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRank
            // 
            btnRank.BackColor = Color.Navy;
            btnRank.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRank.ForeColor = SystemColors.InactiveBorder;
            btnRank.Location = new Point(324, 288);
            btnRank.Name = "btnRank";
            btnRank.Size = new Size(150, 47);
            btnRank.TabIndex = 15;
            btnRank.Text = "Ranking";
            btnRank.UseVisualStyleBackColor = false;
            btnRank.Click += btnRank_Click;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(btnRank);
            Controls.Add(lblFin);
            Controls.Add(lblEm);
            Controls.Add(lblPer);
            Controls.Add(lblGan);
            Controls.Add(btnFin);
            Controls.Add(btnNext);
            Controls.Add(lblRes);
            Controls.Add(btnJugar);
            Controls.Add(rbTijera);
            Controls.Add(rbPapel);
            Controls.Add(rbPiedra);
            Controls.Add(lblRound);
            Controls.Add(lblWel);
            Name = "Juego";
            Text = "Juego";
            Load += Juego_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWel;
        private Label lblRound;
        private RadioButton rbPiedra;
        private RadioButton rbPapel;
        private RadioButton rbTijera;
        private Button btnJugar;
        private Label lblRes;
        private Button btnNext;
        private Button btnFin;
        private Label lblGan;
        private Label lblPer;
        private Label lblEm;
        private Label lblFin;
        private Button btnRank;
    }
}