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
    public partial class Form12 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form12(int score)
        {
            InitializeComponent();
            totalscore = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButton3.Checked;

            if (isCorrect)
            {
                totalscore++;
            }
            Form13 newform = new Form13(totalscore);
            newform.Show();
            this.Hide();
        }
    }
}
