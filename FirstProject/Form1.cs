namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstname = tbFirstName.Text;
            String lastname = tbLastName.Text;
            lbWelcome.Text = "Hello " + firstname + " " + lastname;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            lbWelcome.Text = "";

        }
    }
}