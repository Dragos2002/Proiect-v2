namespace Proiect_v2
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

      

        

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin Back = new Admin();
            this.Hide();
            Back.Show();


        }

        private void buttonSecretar_Click(object sender, EventArgs e)
        {
            Secretar Back = new Secretar();
            this.Hide();
            Back.Show();
        }
    }
}