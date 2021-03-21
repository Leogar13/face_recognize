using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace FaceDetectionApp.View
{
    public partial class Profile : Form
    {
        //Connect        
        DataConnect DataConnectClass = new DataConnect();        
        //Data
        int login;
        public int id;
        string UserName, NameHuman, DescriptionHuman, FaceTrainedLocation, PersonalImageLocation, BirthdayHuman;                
       

        //Close event
        public bool edit = false;        
        public Profile(int idtoshow, int loginer, ref int idtoEdit)
        {
            InitializeComponent();
            edit = false;
            login = loginer;
            id = idtoshow;
            idtoEdit = id;
            //theme for admin
            if (loginer==1)
            {
                LeftPanel.BackColor = Color.Red;
            }
            if (idtoshow == 0 || idtoshow == 1)
            {
                this.BirthdayLabel.Visible = false;
                this.UserNameLabel.Visible = false;
                this.FaceTrainedImage.Visible = false;
                this.IntroduceOfFaceTrained.Visible = false;
            }

            DataConnectClass.ShowPersonProfile(id, ref NameHuman, ref UserName, ref BirthdayHuman, ref DescriptionHuman,ref PersonalImageLocation,ref FaceTrainedLocation);

            if(id==loginer && id!=0 && id!=1 || loginer==1 && id!=0 && id!=1)
            {
                //xem khi la nguoi login hoac la Admin - xem duoc user name
                UserNameText.Text = UserName;
                NameText.Text = NameHuman;
                BirthdayText.Text = BirthdayHuman.ToString();
                DescriptionRichTextBox.Text = "       " + DescriptionHuman;                
                PersonalImage.Image = Image.FromFile(Application.StartupPath + PersonalImageLocation);                 
                FaceTrainedImage.Image = Image.FromFile(Application.StartupPath + FaceTrainedLocation); 
            }
            if (id == 0 || id == 1)
            {
                NameText.Text = NameHuman;            
                BirthdayText.Text = BirthdayHuman.ToString();                
                DescriptionRichTextBox.Text ="       " + DescriptionHuman;
                PersonalImage.BackgroundImage = Image.FromFile(Application.StartupPath + PersonalImageLocation);
            }            
            else
            {                
                NameText.Text = NameHuman;
                BirthdayText.Text = BirthdayHuman.ToString();
                DescriptionRichTextBox.Text = "       " + DescriptionHuman;
                PersonalImage.Image = Image.FromFile(Application.StartupPath + PersonalImageLocation);
                FaceTrainedImage.Image = Image.FromFile(Application.StartupPath + FaceTrainedLocation);
            }

        }        
        
        private void EditBt_Click(object sender, EventArgs e)
        {
            if (login == id || login == 1)
            {                
                edit = true;
                this.Close();                
            }
            else
            {
                MessageBox.Show("You don't have a Permisson to do this", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
