
namespace TestPayPalIntegration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbStatusInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.nudExpYear = new System.Windows.Forms.NumericUpDown();
            this.nudExpMonth = new System.Windows.Forms.NumericUpDown();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardholderName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMemberNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lnkClearRTB = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbStatusInfo
            // 
            this.rtbStatusInfo.Location = new System.Drawing.Point(12, 225);
            this.rtbStatusInfo.Name = "rtbStatusInfo";
            this.rtbStatusInfo.Size = new System.Drawing.Size(299, 249);
            this.rtbStatusInfo.TabIndex = 16;
            this.rtbStatusInfo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CVV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Expiration Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Carholder Name";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(191, 170);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(51, 20);
            this.txtCVV.TabIndex = 14;
            this.txtCVV.Text = "861";
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Location = new System.Drawing.Point(190, 196);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(121, 23);
            this.btnSubmitPayment.TabIndex = 15;
            this.btnSubmitPayment.Text = "Submit Payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.btnSubmitPayment_Click);
            // 
            // nudExpYear
            // 
            this.nudExpYear.Location = new System.Drawing.Point(243, 143);
            this.nudExpYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudExpYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudExpYear.Name = "nudExpYear";
            this.nudExpYear.Size = new System.Drawing.Size(68, 20);
            this.nudExpYear.TabIndex = 12;
            this.nudExpYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // nudExpMonth
            // 
            this.nudExpMonth.Location = new System.Drawing.Point(191, 143);
            this.nudExpMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudExpMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExpMonth.Name = "nudExpMonth";
            this.nudExpMonth.Size = new System.Drawing.Size(51, 20);
            this.nudExpMonth.TabIndex = 11;
            this.nudExpMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(190, 117);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(121, 20);
            this.txtCardNumber.TabIndex = 9;
            this.txtCardNumber.Text = "4111111111111111";
            // 
            // txtCardholderName
            // 
            this.txtCardholderName.Location = new System.Drawing.Point(190, 90);
            this.txtCardholderName.MaxLength = 50;
            this.txtCardholderName.Name = "txtCardholderName";
            this.txtCardholderName.Size = new System.Drawing.Size(121, 20);
            this.txtCardholderName.TabIndex = 7;
            this.txtCardholderName.Text = "Michal Ferber";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(190, 38);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "10.50";
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.Location = new System.Drawing.Point(190, 64);
            this.txtMemberNumber.MaxLength = 12;
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.Size = new System.Drawing.Size(121, 20);
            this.txtMemberNumber.TabIndex = 5;
            this.txtMemberNumber.Text = "2008005000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Member #";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(190, 12);
            this.txtOrderID.MaxLength = 16;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 20);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.Text = "1122569";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order ID";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 23);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lnkClearRTB
            // 
            this.lnkClearRTB.AutoSize = true;
            this.lnkClearRTB.LinkColor = System.Drawing.Color.Blue;
            this.lnkClearRTB.Location = new System.Drawing.Point(13, 206);
            this.lnkClearRTB.Name = "lnkClearRTB";
            this.lnkClearRTB.Size = new System.Drawing.Size(82, 13);
            this.lnkClearRTB.TabIndex = 29;
            this.lnkClearRTB.TabStop = true;
            this.lnkClearRTB.Text = "Clear Messages";
            this.lnkClearRTB.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkClearRTB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearRTB_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 486);
            this.Controls.Add(this.lnkClearRTB);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMemberNumber);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.rtbStatusInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.btnSubmitPayment);
            this.Controls.Add(this.nudExpYear);
            this.Controls.Add(this.nudExpMonth);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtCardholderName);
            this.MaximumSize = new System.Drawing.Size(339, 525);
            this.MinimumSize = new System.Drawing.Size(339, 525);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Braintree Integration Testing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbStatusInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.NumericUpDown nudExpYear;
        private System.Windows.Forms.NumericUpDown nudExpMonth;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCardholderName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMemberNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel lnkClearRTB;
    }
}

