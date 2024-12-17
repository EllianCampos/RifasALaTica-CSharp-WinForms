namespace PRESENTATION
{
    partial class RaffleFormFrm
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
            panel1 = new Panel();
            lblTitle = new Label();
            btnAddRaffle = new Button();
            pictureBox1 = new PictureBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            errorProvider1 = new ErrorProvider(components);
            dtpDate = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnAddRaffle);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(74, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Crear Sorteo";
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
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(32, 106);
            txtName.Name = "txtName";
            txtName.Size = new Size(400, 29);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 82);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 3;
            label2.Text = "Nombre del sorteo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 236);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 7;
            label4.Text = "Valor del número";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(32, 260);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(400, 29);
            txtPrice.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save_32x32;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(32, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(400, 48);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkRed;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete_32x32;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(32, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(400, 48);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(32, 183);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(400, 29);
            dtpDate.TabIndex = 10;
            // 
            // RaffleFormFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "RaffleFormFrm";
            Text = "Rifas a la Tica";
            Load += RaffleFormFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Button btnAddRaffle;
        private PictureBox pictureBox1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnDelete;
        private ErrorProvider errorProvider1;
        private DateTimePicker dtpDate;
    }
}