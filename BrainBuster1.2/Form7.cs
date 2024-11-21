using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainBuster1._2
{
    public partial class Form7 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form7(int score)
        {
            InitializeComponent();
            totalscore = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isCorrect = radioButton2.Checked;

            if (isCorrect)
            {
                totalscore++;
            }
            Form8 newform = new Form8(totalscore);
            newform.StartPosition = FormStartPosition.Manual;
            newform.Location = this.Location;
            newform.Show();
            this.Hide();
        }
    }
}
