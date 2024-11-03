namespace FinalEF
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
            btnGet = new Button();
            txtGet = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblDescription = new Label();
            lblUnitPrice = new Label();
            lblOnHandQuantity = new Label();
            btnExit = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(454, 45);
            btnGet.Margin = new Padding(4, 5, 4, 5);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(153, 38);
            btnGet.TabIndex = 0;
            btnGet.Text = "Get Product";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtGet
            // 
            txtGet.Location = new Point(204, 45);
            txtGet.Margin = new Padding(4, 5, 4, 5);
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(240, 31);
            txtGet.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Product Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(53, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 30);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(71, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 30);
            label3.TabIndex = 4;
            label3.Text = "Unit Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(17, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 30);
            label4.TabIndex = 5;
            label4.Text = "OnHandQuantity:";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = SystemColors.Info;
            lblDescription.Location = new Point(204, 147);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(407, 48);
            lblDescription.TabIndex = 6;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.BackColor = SystemColors.Info;
            lblUnitPrice.Location = new Point(204, 217);
            lblUnitPrice.Margin = new Padding(4, 0, 4, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(221, 48);
            lblUnitPrice.TabIndex = 7;
            // 
            // lblOnHandQuantity
            // 
            lblOnHandQuantity.BackColor = SystemColors.Info;
            lblOnHandQuantity.Location = new Point(204, 295);
            lblOnHandQuantity.Margin = new Padding(4, 0, 4, 0);
            lblOnHandQuantity.Name = "lblOnHandQuantity";
            lblOnHandQuantity.Size = new Size(221, 48);
            lblOnHandQuantity.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(400, 400);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(129, 83);
            btnExit.TabIndex = 9;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(109, 400);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 83);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "A&dd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(679, 528);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(lblOnHandQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGet);
            Controls.Add(btnGet);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Product Maintenance";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private TextBox txtGet;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDescription;
        private Label lblUnitPrice;
        private Label lblOnHandQuantity;
        private Button btnExit;
        private Button btnAdd;
    }
}
