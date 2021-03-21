using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceDetectionApp.View;

namespace FaceDetectionApp
{
    public partial class PictureButton : UserControl
    {
        DataConnect data = new DataConnect();        
        int login;
        int edit;
        private int IDperson;        

        public int ChangeIDperson
        {
            get { return IDperson; }
            set { IDperson = value; }
        }

        public PictureButton(int login,int id)
        {
            InitializeComponent();            
            this.BackColor = Color.White;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.ForeColor = Color.Black;

            this.IDperson = id;
            edit = id;
            this.login = login;

        }

        private void PictureButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(IDperson,login, ref edit);

            profile.Show();
        }
    }
}
