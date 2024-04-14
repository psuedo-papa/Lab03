namespace Lab03
{
    partial class Form3
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
            lstShop = new ListBox();
            lstCart = new ListBox();
            txtFruit = new TextBox();
            btnFruit = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            btnCount = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lstShop
            // 
            lstShop.FormattingEnabled = true;
            lstShop.ItemHeight = 25;
            lstShop.Items.AddRange(new object[] { "Apple", "Banana", "Grape", "Orange", "Peach", "Pear", "Pineapple" });
            lstShop.Location = new Point(50, 101);
            lstShop.Name = "lstShop";
            lstShop.Size = new Size(245, 379);
            lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            lstCart.FormattingEnabled = true;
            lstCart.ItemHeight = 25;
            lstCart.Location = new Point(506, 101);
            lstCart.Name = "lstCart";
            lstCart.Size = new Size(245, 379);
            lstCart.TabIndex = 1;
            // 
            // txtFruit
            // 
            txtFruit.Location = new Point(149, 536);
            txtFruit.Name = "txtFruit";
            txtFruit.Size = new Size(213, 31);
            txtFruit.TabIndex = 2;
            // 
            // btnFruit
            // 
            btnFruit.Location = new Point(135, 623);
            btnFruit.Name = "btnFruit";
            btnFruit.Size = new Size(149, 46);
            btnFruit.TabIndex = 3;
            btnFruit.Text = "AddFruit";
            btnFruit.UseVisualStyleBackColor = true;
            btnFruit.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 539);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "AddFruit";
            // 
            // button2
            // 
            button2.Location = new Point(342, 101);
            button2.Name = "button2";
            button2.Size = new Size(116, 44);
            button2.TabIndex = 5;
            button2.Text = "-->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(342, 206);
            button3.Name = "button3";
            button3.Size = new Size(116, 44);
            button3.TabIndex = 6;
            button3.Text = "<--";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(412, 623);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(151, 67);
            btnCount.TabIndex = 7;
            btnCount.Text = "Count Shop + Cart";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(600, 623);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 67);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear Cart";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 912);
            Controls.Add(btnClear);
            Controls.Add(btnCount);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnFruit);
            Controls.Add(txtFruit);
            Controls.Add(lstCart);
            Controls.Add(lstShop);
            Name = "Form3";
            Text = "Shopping Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstShop;
        private ListBox lstCart;
        private TextBox txtFruit;
        private Button btnFruit;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button btnCount;
        private Button btnClear;
    }
}