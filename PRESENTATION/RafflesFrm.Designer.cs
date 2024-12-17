namespace PRESENTATION
{
    partial class RafflesFrm
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
            panel1 = new Panel();
            label1 = new Label();
            btnAddRaffle = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalItems = new Label();
            cbItemsPerPage = new ComboBox();
            cbPageNumber = new ComboBox();
            dgvRaffles = new DataGridView();
            txtTotalPages = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRaffles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAddRaffle);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Sorteos";
            // 
            // btnAddRaffle
            // 
            btnAddRaffle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRaffle.BackColor = Color.Green;
            btnAddRaffle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRaffle.ForeColor = Color.White;
            btnAddRaffle.Location = new Point(680, 3);
            btnAddRaffle.Name = "btnAddRaffle";
            btnAddRaffle.Size = new Size(117, 44);
            btnAddRaffle.TabIndex = 2;
            btnAddRaffle.Text = "Crear Sorteo";
            btnAddRaffle.UseVisualStyleBackColor = false;
            btnAddRaffle.Click += btnAddRaffle_Click;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 412);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Mostrar";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 412);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 2;
            label3.Text = "por página";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(485, 412);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 3;
            label4.Text = "Página";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(611, 412);
            label5.Name = "label5";
            label5.Size = new Size(27, 21);
            label5.TabIndex = 4;
            label5.Text = "de";
            // 
            // lblTotalItems
            // 
            lblTotalItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalItems.AutoSize = true;
            lblTotalItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalItems.Location = new Point(708, 412);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(80, 21);
            lblTotalItems.TabIndex = 5;
            lblTotalItems.Text = "(50) items";
            // 
            // cbItemsPerPage
            // 
            cbItemsPerPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbItemsPerPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbItemsPerPage.FormattingEnabled = true;
            cbItemsPerPage.Items.AddRange(new object[] { "5", "10", "20", "50" });
            cbItemsPerPage.Location = new Point(83, 409);
            cbItemsPerPage.Name = "cbItemsPerPage";
            cbItemsPerPage.Size = new Size(58, 29);
            cbItemsPerPage.TabIndex = 6;
            cbItemsPerPage.SelectedIndexChanged += cbItemsPerPage_SelectedIndexChanged;
            // 
            // cbPageNumber
            // 
            cbPageNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbPageNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPageNumber.FormattingEnabled = true;
            cbPageNumber.Location = new Point(547, 409);
            cbPageNumber.Name = "cbPageNumber";
            cbPageNumber.Size = new Size(58, 29);
            cbPageNumber.TabIndex = 8;
            cbPageNumber.SelectionChangeCommitted += cbPageNumber_SelectionChangeCommitted;
            // 
            // dgvRaffles
            // 
            dgvRaffles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRaffles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRaffles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaffles.Location = new Point(12, 56);
            dgvRaffles.Name = "dgvRaffles";
            dgvRaffles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRaffles.Size = new Size(776, 347);
            dgvRaffles.TabIndex = 9;
            dgvRaffles.CellDoubleClick += dgvRaffles_CellDoubleClick;
            // 
            // txtTotalPages
            // 
            txtTotalPages.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotalPages.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPages.Location = new Point(644, 409);
            txtTotalPages.Name = "txtTotalPages";
            txtTotalPages.ReadOnly = true;
            txtTotalPages.Size = new Size(58, 29);
            txtTotalPages.TabIndex = 10;
            // 
            // RafflesFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalPages);
            Controls.Add(dgvRaffles);
            Controls.Add(cbPageNumber);
            Controls.Add(cbItemsPerPage);
            Controls.Add(lblTotalItems);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "RafflesFrm";
            Text = "Rifas a la Tica";
            Load += RafflesFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRaffles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAddRaffle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotalItems;
        private ComboBox cbItemsPerPage;
        private ComboBox cbPageNumber;
        private DataGridView dgvRaffles;
        private TextBox txtTotalPages;
    }
}
