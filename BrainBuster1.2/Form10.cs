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
    public partial class Form10 : Form
    {
        private int totalscore;
        private int score = 0;
        public Form10(int score)
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
            Form11 newform = new Form11(totalscore);
            newform.StartPosition = FormStartPosition.Manual;
            newform.Location = this.Location;
            newform.Show();
            this.Hide();
        }
    }
    }
