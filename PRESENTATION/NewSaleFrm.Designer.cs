namespace PRESENTATION
{
    partial class NewSaleFrm
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
            btnAddRaffle = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtClient = new TextBox();
            cbPaymentMethod = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtDetails = new TextBox();
            listBox = new ListBox();
            panel3 = new Panel();
            btnFinish = new Button();
            label9 = new Label();
            lblNumCount = new Label();
            lblNumPrice = new Label();
            label8 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            cbNumber = new ComboBox();
            label5 = new Label();
            btnRemove = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 12);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Nueva Venta";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre del cliente";
            // 
            // txtClient
            // 
            txtClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClient.Location = new Point(12, 98);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(400, 29);
            txtClient.TabIndex = 3;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(12, 163);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(400, 29);
            cbPaymentMethod.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 5;
            label3.Text = "Método de pago";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 6;
            label4.Text = "Detalles";
            // 
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetails.Location = new Point(12, 238);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(400, 29);
            txtDetails.TabIndex = 7;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 21;
            listBox.Location = new Point(536, 133);
            listBox.Name = "listBox";
            listBox.Size = new Size(250, 298);
            listBox.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.MenuText;
            panel3.Controls.Add(btnFinish);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblNumCount);
            panel3.Controls.Add(lblNumPrice);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 315);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 116);
            panel3.TabIndex = 13;
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinish.Location = new Point(284, 11);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(103, 94);
            btnFinish.TabIndex = 22;
            btnFinish.Text = "Finalizar Venta";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(6, 75);
            label9.Name = "label9";
            label9.Size = new Size(73, 30);
            label9.TabIndex = 21;
            label9.Text = "Total: ";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumCount
            // 
            lblNumCount.AutoSize = true;
            lblNumCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumCount.ForeColor = Color.White;
            lblNumCount.Location = new Point(171, 42);
            lblNumCount.Name = "lblNumCount";
            lblNumCount.Size = new Size(19, 21);
            lblNumCount.TabIndex = 20;
            lblNumCount.Text = "0";
            // 
            // lblNumPrice
            // 
            lblNumPrice.AutoSize = true;
            lblNumPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumPrice.ForeColor = Color.White;
            lblNumPrice.Location = new Point(171, 11);
            lblNumPrice.Name = "lblNumPrice";
            lblNumPrice.Size = new Size(19, 21);
            lblNumPrice.TabIndex = 19;
            lblNumPrice.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 42);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 18;
            label8.Text = "Cantidad de números:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(81, 75);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(25, 30);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 17;
            label6.Text = "Valor del número:";
            // 
            // cbNumber
            // 
            cbNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNumber.FormattingEnabled = true;
            cbNumber.Items.AddRange(new object[] { "10", "15", "20" });
            cbNumber.Location = new Point(536, 98);
            cbNumber.Name = "cbNumber";
            cbNumber.Size = new Size(250, 29);
            cbNumber.TabIndex = 12;
            cbNumber.SelectedIndexChanged += cbNumber_SelectedIndexChanged;
            cbNumber.KeyPress += cbNumber_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(536, 74);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 11;
            label5.Text = "Número";
            // 
            // btnRemove
            // 
            btnRemove.BackgroundImage = Properties.Resources.delete_32x32;
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.Location = new Point(485, 386);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(45, 45);
            btnRemove.TabIndex = 16;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 291);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 18;
            label7.Text = "Detalles";
            // 
            // NewSaleFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btnRemove);
            Controls.Add(panel3);
            Controls.Add(listBox);
            Controls.Add(label5);
            Controls.Add(cbNumber);
            Controls.Add(txtDetails);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbPaymentMethod);
            Controls.Add(txtClient);
            Controls.Add(label2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "NewSaleFrm";
            Text = "Rifas a la Tica";
            Load += SalesFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAddRaffle;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtClient;
        private ComboBox cbPaymentMethod;
        private Label label3;
        private Label label4;
        private TextBox txtDetails;
        private Panel panel3;
        private Label lblTotal;
        private ComboBox cbNumber;
        private Label label5;
        private ListBox listBox;
        private Button btnRemove;
        private Label label6;
        private Label label7;
        private Label lblNumPrice;
        private Label label8;
        private Label label9;
        private Label lblNumCount;
        private Button btnFinish;
    }
}