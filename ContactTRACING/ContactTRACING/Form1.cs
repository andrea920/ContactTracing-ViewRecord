using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactTRACING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\PeopleEntry\\" + "Data.txt");
            var date01 = DateTime.Now;

            //Date and Time
            A.WriteLine(date01.ToLongDateString());
            A.WriteLine(date01.ToShortTimeString());

            A.WriteLine(lblName.Text + " " + txtbxName.Text);//Name
            A.WriteLine(lblAge.Text + " " + txtbxAge.Text);//Age
            A.WriteLine(lblAddress.Text + " " + txtbxAddress.Text);//Address
            A.WriteLine(lblEmail.Text + " " + txtbxEmail.Text);//Email
            A.WriteLine(lblPhoneNum.Text + " " + txtbxPhoneNum.Text);//PhoneNumber

            //Gender
            if (radMale.Checked == true)
            {
                A.WriteLine(radMale.Text);
            }
            else
            {
                A.WriteLine(radFemale.Text);
            }

            //Temperature
            A.WriteLine(lblTemp.Text + " " + txtbxTemp.Text);

            //Vaccination
            if (rad1stdose.Checked == true)
            {
                A.WriteLine(gbxVax.Text + " " + rad1stdose.Text);
            }
            else if (radFullVax.Checked == true)
            {
                A.WriteLine(gbxVax.Text + " " + radFullVax.Text);
            }
            else
            {
                A.WriteLine(gbxVax.Text + " " + radNot.Text);
            }

            //Checkbox
            A.WriteLine(gbxQuestions.Text + " " + " ");
            if (cbFever.Checked == true)
            {
                A.WriteLine(cbFever.Text);
            }
            if (cbCough.Checked == true)
            {
                A.WriteLine(cbCough.Text);
            }
            if (cbColds.Checked == true)
            {
                A.WriteLine(cbColds.Text);
            }
            if (cbSorethroat.Checked == true)
            {
                A.WriteLine(cbSorethroat.Text);
            }
            if (cbDiffBreathing.Checked == true)
            {
                A.WriteLine(cbDiffBreathing.Text);
            }
            if (cbDiarrhea.Checked == true)
            {
                A.WriteLine(cbDiarrhea.Text);
            }
            else if (cbIhave.Checked == true)
            {
                A.WriteLine(cbIhave.Text);
            }
            A.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    RtxtBx.Text = filetext;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RtxtBx.Clear();
        }
    }
}
