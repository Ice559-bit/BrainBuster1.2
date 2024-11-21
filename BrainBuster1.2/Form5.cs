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
    public partial class Form5 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form5(int score)
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
            Form6 newform = new Form6(totalscore);
            newform.StartPosition = FormStartPosition.Manual;
            newform.Location = this.Location;
            newform.Show();
            this.Hide();
        }
    }
}
