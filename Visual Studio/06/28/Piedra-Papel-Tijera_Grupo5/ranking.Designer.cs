namespace Piedra_Papel_Tijera_Grupo5
{
    partial class ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ranking));
            label1 = new Label();
            lstRank = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 38);
            label1.Name = "label1";
            label1.Size = new Size(192, 50);
            label1.TabIndex = 0;
            label1.Text = "RANKING";
            // 
            // lstRank
            // 
            lstRank.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstRank.ForeColor = SystemColors.HotTrack;
            lstRank.FormattingEnabled = true;
            lstRank.ItemHeight = 28;
            lstRank.Location = new Point(224, 103);
            lstRank.Name = "lstRank";
            lstRank.Size = new Size(340, 200);
            lstRank.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DodgerBlue;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.InactiveBorder;
            btnClose.Location = new Point(320, 327);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 47);
            btnClose.TabIndex = 16;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ranking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(btnClose);
            Controls.Add(lstRank);
            Controls.Add(label1);
            Name = "ranking";
            Text = "ranking";
            Load += ranking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstRank;
        private Button btnClose;
    }
}