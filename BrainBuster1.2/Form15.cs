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
    public partial class Form15 : Form
    {
        private int totalscore;
        public Form15(int score)
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
            Form16 newform = new Form16(totalscore);
            newform.Show();
            this.Hide();
        }
    }
}
