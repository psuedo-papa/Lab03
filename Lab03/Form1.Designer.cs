namespace Lab03
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
            lblCast = new Label();
            cboMovie = new ComboBox();
            btnCast = new Button();
            SuspendLayout();
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Location = new Point(91, 79);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(260, 25);
            lblCast.TabIndex = 0;
            lblCast.Text = "My Choice of Best Movie Series";
            // 
            // cboMovie
            // 
            cboMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovie.FormattingEnabled = true;
            cboMovie.Items.AddRange(new object[] { "The Godfather", "Terminator", "Back to the Future", "Matrix" });
            cboMovie.Location = new Point(91, 154);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(260, 33);
            cboMovie.TabIndex = 1;
            // 
            // btnCast
            // 
            btnCast.Location = new Point(91, 243);
            btnCast.Name = "btnCast";
            btnCast.Size = new Size(191, 49);
            btnCast.TabIndex = 2;
            btnCast.Text = "Cast your vote";
            btnCast.UseVisualStyleBackColor = true;
            btnCast.Click += btnCast_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 904);
            Controls.Add(btnCast);
            Controls.Add(cboMovie);
            Controls.Add(lblCast);
            Name = "Form1";
            Text = "Lab03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCast;
        private ComboBox cboMovie;
        private Button btnCast;
    }
}
