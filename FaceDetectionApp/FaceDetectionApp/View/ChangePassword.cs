using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetectionApp.View
{
    public partial class ChangePassword : Form
    {
        DataConnect data = new DataConnect();
        int id;
        public ChangePassword(int id)
        {
            InitializeComponent();
            this.id = id;            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OldPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter your recent password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (string.IsNullOrWhiteSpace(NewPasswordTextBox.Text) || string.IsNullOrWhiteSpace(ConfirmTextBox.Text))
            {
                if (string.Equals(NewPasswordTextBox.Text, ConfirmTextBox.Text))
                {
                    data.getsetPass(id, OldPasswordTextBox.Text, NewPasswordTextBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your confirm is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter full path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
