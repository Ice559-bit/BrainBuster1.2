using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace BrainBuster1._2
{
    public partial class Form11 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form11(int score)
        {
            InitializeComponent();
            totalscore = score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCorrect = radioButton4.Checked;

            if (isCorrect)
            {
                totalscore++;
            }
            Form12 newform = new Form12(totalscore);
            newform.Show();
            this.Hide();
        }
    }
}
