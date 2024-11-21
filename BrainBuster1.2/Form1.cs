namespace BrainBuster1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.StartPosition = FormStartPosition.Manual; 
            newform.Location = this.Location;
            newform.Show();
            this.Hide();
        }
    }
}
