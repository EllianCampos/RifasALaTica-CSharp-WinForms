namespace PRESENTATION
{
    partial class SalesFrm
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
            dgvSales = new DataGridView();
            panel1 = new Panel();
            lblRafleName = new Label();
            label1 = new Label();
            btnAddRaffle = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(12, 62);
            dgvSales.Name = "dgvSales";
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(776, 376);
            dgvSales.TabIndex = 19;
            dgvSales.CellDoubleClick += dgvSales_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblRafleName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddRaffle);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 10;
            // 
            // lblRafleName
            // 
            lblRafleName.AutoSize = true;
            lblRafleName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRafleName.ForeColor = Color.DodgerBlue;
            lblRafleName.Location = new Point(222, 12);
            lblRafleName.Name = "lblRafleName";
            lblRafleName.Size = new Size(203, 25);
            lblRafleName.TabIndex = 3;
            lblRafleName.Text = "Rifa diá de las madres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Ventas Sorteo:";
            // 
            // btnAddRaffle
            // 
            btnAddRaffle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRaffle.BackColor = Color.Green;
            btnAddRaffle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRaffle.ForeColor = Color.White;
            btnAddRaffle.Location = new Point(1280, 3);
            btnAddRaffle.Name = "btnAddRaffle";
            btnAddRaffle.Size = new Size(117, 44);
            btnAddRaffle.TabIndex = 2;
            btnAddRaffle.Text = "Crear Sorteo";
            btnAddRaffle.UseVisualStyleBackColor = false;
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
            // SalesFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSales);
            Controls.Add(panel1);
            Name = "SalesFrm";
            Text = "Rifas a la Tica";
            Load += SalesFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSales;
        private Panel panel1;
        private Label label1;
        private Button btnAddRaffle;
        private PictureBox pictureBox1;
        private Label lblRafleName;
    }
}