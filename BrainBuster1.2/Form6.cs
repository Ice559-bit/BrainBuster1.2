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
    public partial class Form6 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form6(int score)
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
            Form7 newform = new Form7(totalscore);
            newform.StartPosition = FormStartPosition.Manual;
            newform.Location = this.Location;
            newform.Show();
            this.Hide();
        }
    }
}
