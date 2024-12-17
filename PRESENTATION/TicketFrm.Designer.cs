namespace PRESENTATION
{
    partial class TicketFrm
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
            lblRafleName = new Label();
            label1 = new Label();
            btnAddRaffle = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblNumbers = new Label();
            label5 = new Label();
            lblClient = new Label();
            lblPrice = new Label();
            lblCount = new Label();
            lblTotal = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(516, 50);
            panel1.TabIndex = 11;
            // 
            // lblRafleName
            // 
            lblRafleName.AutoSize = true;
            lblRafleName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRafleName.ForeColor = Color.DodgerBlue;
            lblRafleName.Location = new Point(158, 12);
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
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Sorteo:";
            // 
            // btnAddRaffle
            // 
            btnAddRaffle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRaffle.BackColor = Color.Green;
            btnAddRaffle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRaffle.ForeColor = Color.White;
            btnAddRaffle.Location = new Point(1596, 3);
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 12;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 13;
            label3.Text = "Valor del número:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(177, 21);
            label4.TabIndex = 14;
            label4.Text = "Cantidad de números:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuText;
            panel2.Controls.Add(lblNumbers);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 225);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 50);
            panel2.TabIndex = 15;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumbers.ForeColor = Color.Gold;
            lblNumbers.Location = new Point(108, 11);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(98, 25);
            lblNumbers.TabIndex = 4;
            lblNumbers.Text = "00, 03, 99";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 4;
            label5.Text = "Numeros:";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClient.Location = new Point(86, 83);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(58, 21);
            lblClient.TabIndex = 16;
            lblClient.Text = "Cliente";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(164, 112);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(19, 21);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "0";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(195, 141);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(19, 21);
            lblCount.TabIndex = 18;
            lblCount.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(195, 170);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 21);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 170);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 19;
            label7.Text = "Cantidad de números:";
            // 
            // TicketFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 275);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(lblCount);
            Controls.Add(lblPrice);
            Controls.Add(lblClient);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "TicketFrm";
            Text = "Rifas a la Tica";
            Load += TicketFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblRafleName;
        private Label label1;
        private Button btnAddRaffle;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label lblNumbers;
        private Label label5;
        private Label lblClient;
        private Label lblPrice;
        private Label lblCount;
        private Label lblTotal;
        private Label label7;
    }
}