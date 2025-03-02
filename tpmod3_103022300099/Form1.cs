namespace tpmod3_103022300099
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            label1.Text = "Halo  " + text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
