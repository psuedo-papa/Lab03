namespace Lab03
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
            lblAmount = new Label();
            lblRate = new Label();
            lblValue = new Label();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            btnCalculate = new Button();
            lblValue2 = new Label();
            lblMillion = new Label();
            lblMillion2 = new Label();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(53, 62);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(77, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            lblRate.Location = new Point(53, 126);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(117, 53);
            lblRate.TabIndex = 1;
            lblRate.Text = "Interest Rate (Annual)";
            // 
            // lblValue
            // 
            lblValue.Location = new Point(53, 313);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(123, 54);
            lblValue.TabIndex = 2;
            lblValue.Text = "Value after 10 years";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(257, 59);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 31);
            txtAmount.TabIndex = 3;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(257, 148);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(150, 31);
            txtRate.TabIndex = 4;
            txtRate.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(113, 224);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(232, 44);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Start Calculation";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblValue2
            // 
            lblValue2.BorderStyle = BorderStyle.Fixed3D;
            lblValue2.Location = new Point(257, 313);
            lblValue2.Name = "lblValue2";
            lblValue2.Size = new Size(150, 44);
            lblValue2.TabIndex = 6;
            lblValue2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMillion
            // 
            lblMillion.Location = new Point(53, 419);
            lblMillion.Name = "lblMillion";
            lblMillion.Size = new Size(124, 52);
            lblMillion.TabIndex = 7;
            lblMillion.Text = "Years to reach $1M";
            // 
            // lblMillion2
            // 
            lblMillion2.BorderStyle = BorderStyle.Fixed3D;
            lblMillion2.Location = new Point(257, 419);
            lblMillion2.Name = "lblMillion2";
            lblMillion2.Size = new Size(150, 52);
            lblMillion2.TabIndex = 8;
            lblMillion2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 780);
            Controls.Add(lblMillion2);
            Controls.Add(lblMillion);
            Controls.Add(lblValue2);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Controls.Add(lblValue);
            Controls.Add(lblRate);
            Controls.Add(lblAmount);
            Name = "Form2";
            Text = "Compound Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblRate;
        private Label lblValue;
        private TextBox txtAmount;
        private TextBox txtRate;
        private Button btnCalculate;
        private Label lblValue2;
        private Label lblMillion;
        private Label lblMillion2;
    }
}