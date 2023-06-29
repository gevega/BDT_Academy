namespace Piedra_Papel_Tijera_Grupo5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnacept = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnacept
            // 
            btnacept.BackColor = SystemColors.Highlight;
            btnacept.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnacept.ForeColor = Color.White;
            btnacept.Location = new Point(291, 192);
            btnacept.Name = "btnacept";
            btnacept.Size = new Size(211, 109);
            btnacept.TabIndex = 0;
            btnacept.Text = "JUGAR";
            btnacept.UseVisualStyleBackColor = false;
            btnacept.Click += btnacept_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 31);
            label1.Name = "label1";
            label1.Size = new Size(663, 72);
            label1.TabIndex = 1;
            label1.Text = "PIEDRA / PAPEL / TIJERA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(164, 114);
            label2.Name = "label2";
            label2.Size = new Size(475, 46);
            label2.TabIndex = 2;
            label2.Text = "EL RENACER DE LAS TIJERAS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnacept);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnacept;
        private Label label1;
        private Label label2;
    }
}