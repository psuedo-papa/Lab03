namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You voted for:\n" + cboMovie.Text);
        }
    }
}
