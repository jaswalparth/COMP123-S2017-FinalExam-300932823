using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
     Name: Parth Jaswal
     date:17 Aug 2017    
     studentID:300932823
     Description: this is splash form
     version: 0.2
     */
namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            PickHighestCardForm pick = new PickHighestCardForm();
            pick.Show();
        }

        private void SpalshForm_Click(object sender, EventArgs e)
        {

        }
    }
}
