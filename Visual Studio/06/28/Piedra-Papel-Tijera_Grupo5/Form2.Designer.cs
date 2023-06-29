namespace Piedra_Papel_Tijera_Grupo5
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            txtjug = new TextBox();
            txtcant = new TextBox();
            txtnom = new TextBox();
            label3 = new Label();
            lstnom = new ListBox();
            btnStart = new Button();
            btnadd = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnAcept1 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(230, 28);
            label1.Name = "label1";
            label1.Size = new Size(260, 32);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de jugadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(230, 69);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de rondas";
            // 
            // txtjug
            // 
            txtjug.Location = new Point(524, 34);
            txtjug.Name = "txtjug";
            txtjug.Size = new Size(53, 27);
            txtjug.TabIndex = 2;
            // 
            // txtcant
            // 
            txtcant.Location = new Point(524, 75);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(53, 27);
            txtcant.TabIndex = 3;
            // 
            // txtnom
            // 
            txtnom.Location = new Point(230, 187);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(347, 27);
            txtnom.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 156);
            label3.Name = "label3";
            label3.Size = new Size(310, 28);
            label3.TabIndex = 5;
            label3.Text = "Ingrese nombre de participantes";
            // 
            // lstnom
            // 
            lstnom.FormattingEnabled = true;
            lstnom.ItemHeight = 20;
            lstnom.Location = new Point(230, 265);
            lstnom.Name = "lstnom";
            lstnom.Size = new Size(347, 84);
            lstnom.TabIndex = 6;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.Highlight;
            btnStart.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(455, 355);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(122, 35);
            btnStart.TabIndex = 7;
            btnStart.Text = "Comenzar";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnacept_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = SystemColors.Highlight;
            btnadd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(455, 220);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(122, 35);
            btnadd.TabIndex = 8;
            btnadd.Text = "Agregar";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnAcept1
            // 
            btnAcept1.BackColor = SystemColors.Highlight;
            btnAcept1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcept1.ForeColor = Color.White;
            btnAcept1.Location = new Point(455, 108);
            btnAcept1.Name = "btnAcept1";
            btnAcept1.Size = new Size(122, 35);
            btnAcept1.TabIndex = 9;
            btnAcept1.Text = "Aceptar";
            btnAcept1.UseVisualStyleBackColor = false;
            btnAcept1.Click += btnAcept1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(802, 453);
            Controls.Add(btnAcept1);
            Controls.Add(btnadd);
            Controls.Add(btnStart);
            Controls.Add(lstnom);
            Controls.Add(label3);
            Controls.Add(txtnom);
            Controls.Add(txtcant);
            Controls.Add(txtjug);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtjug;
        private TextBox txtcant;
        private TextBox txtnom;
        private Label label3;
        private ListBox lstnom;
        private Button btnStart;
        private Button btnadd;
        private ErrorProvider errorProvider1;
        private Button btnAcept1;
    }
}