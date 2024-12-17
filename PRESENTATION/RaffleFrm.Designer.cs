namespace PRESENTATION
{
    partial class RaffleFrm
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
            panel1 = new Panel();
            label1 = new Label();
            lblRafleName = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btnNewSale = new Button();
            btnSales = new Button();
            btnReport = new Button();
            btnSettings = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblRafleName);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 12);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 3;
            label1.Text = "Sorteo:";
            // 
            // lblRafleName
            // 
            lblRafleName.AutoSize = true;
            lblRafleName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRafleName.ForeColor = Color.DodgerBlue;
            lblRafleName.Location = new Point(156, 12);
            lblRafleName.Name = "lblRafleName";
            lblRafleName.Size = new Size(203, 25);
            lblRafleName.TabIndex = 0;
            lblRafleName.Text = "Rifa diá de las madres";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1280, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 2;
            button1.Text = "Crear Sorteo";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.favicon;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnNewSale
            // 
            btnNewSale.Anchor = AnchorStyles.Top;
            btnNewSale.BackColor = Color.Green;
            btnNewSale.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewSale.ForeColor = Color.White;
            btnNewSale.Location = new Point(97, 56);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(300, 175);
            btnNewSale.TabIndex = 2;
            btnNewSale.Text = "Nueva Venta";
            btnNewSale.UseVisualStyleBackColor = false;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnSales
            // 
            btnSales.Anchor = AnchorStyles.Top;
            btnSales.BackColor = Color.FromArgb(198, 79, 0);
            btnSales.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(403, 56);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(300, 175);
            btnSales.TabIndex = 3;
            btnSales.Text = "Ventas";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top;
            btnReport.BackColor = Color.FromArgb(12, 38, 55);
            btnReport.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(97, 237);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(300, 175);
            btnReport.TabIndex = 4;
            btnReport.Text = "Reporte";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top;
            btnSettings.BackColor = Color.FromArgb(64, 64, 64);
            btnSettings.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(403, 237);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(300, 175);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "Ajustes del Sorteo";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // RaffleFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSettings);
            Controls.Add(btnReport);
            Controls.Add(btnSales);
            Controls.Add(btnNewSale);
            Controls.Add(panel1);
            Name = "RaffleFrm";
            Text = "Rifas a la Tica";
            Load += RaffleFrm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblRafleName;
        private Button button1;
        private PictureBox pictureBox1;
        private Button btnNewSale;
        private Button btnSales;
        private Button btnReport;
        private Button btnSettings;
        private Label label1;
    }
}