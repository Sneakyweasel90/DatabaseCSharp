namespace FinalEF
{
    partial class FrmAdd
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
            btnAccept = new Button();
            btnCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtProductCode = new TextBox();
            txtDescription = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantOnHand = new TextBox();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(75, 368);
            btnAccept.Margin = new Padding(4, 5, 4, 5);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(216, 83);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "A&ccept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(367, 368);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(216, 83);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 285);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 9;
            label4.Text = "Quantity on Hand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 8;
            label3.Text = "Unit Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 7;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 6;
            label1.Text = "Product Code:";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(200, 35);
            txtProductCode.Margin = new Padding(4, 5, 4, 5);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(398, 31);
            txtProductCode.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 137);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(398, 31);
            txtDescription.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(200, 202);
            txtUnitPrice.Margin = new Padding(4, 5, 4, 5);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(240, 31);
            txtUnitPrice.TabIndex = 2;
            // 
            // txtQuantOnHand
            // 
            txtQuantOnHand.Location = new Point(200, 280);
            txtQuantOnHand.Margin = new Padding(4, 5, 4, 5);
            txtQuantOnHand.Name = "txtQuantOnHand";
            txtQuantOnHand.Size = new Size(240, 31);
            txtQuantOnHand.TabIndex = 3;
            // 
            // FrmAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(667, 508);
            Controls.Add(txtQuantOnHand);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtDescription);
            Controls.Add(btnAccept);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductCode);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmAdd";
            Text = "Add/Modify Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Button btnCancel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProductCode;
        private TextBox txtDescription;
        private TextBox txtUnitPrice;
        private TextBox txtQuantOnHand;
    }
}