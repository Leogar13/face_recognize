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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Cuda;
using Emgu.CV.Face;
using System.Drawing.Drawing2D;
using FaceDetectionApp.View;
using System.Drawing.Imaging;
using DirectShowLib;
using System.Threading;

namespace FaceDetectionApp
{
    public partial class FaceDetection : Form
    {
        //Connect
        DataConnect data = new DataConnect();
        //Login
        int login = 0;
        //Check image for save
        private bool Training = false;
        private Boolean photo = false;
        private Boolean picture = false;
        //Take all of camera in device
        int indexofCamera;
        List<KeyValuePair<int, string>> ListofCamera = new List<KeyValuePair<int, string>>(); //list Camera name and index        
        VideoCapture capture = new VideoCapture(); //create a camera captue default
        //For face Recognize
        List<int> IDofPerson = new List<int>();
        List<int> Recognized = new List<int>();
        List<Image<Gray, byte>> FaceTrainedFolder = new List<Image<Gray, byte>>();
        Image<Gray, byte> trainface;
        CascadeClassifier cascade = new CascadeClassifier("haarcascade_frontalface_default.xml");
        Rectangle[] faces;
        //FaceRecognizer facerecognize = new EigenFaceRecognizer(80, double.PositiveInfinity);
        DsDevice[] device = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
        //FaceRecognizer faceRecognizer;
        FaceRecognizer faceRecognizer;
        //face trained in run-time
        Mat CameratoImage = new Mat();
        Mat DrawtoCamera = new Mat();
        Mat grayim = new Mat();

        //test
        //Mat t = new Mat("C:\\Users\\VAIO\\Desktop\\test.png",ImreadModes.LoadGdal);
        

        //For EditProfile
        string EP_UserName, EP_NameHuman, EP_DescriptionHuman, EP_FaceTrainedLocation, EP_PersonalImageLocation, EP_BirthdayHuman;
        int IDtoEditProfile= 0;

        public FaceDetection()
        {
            InitializeComponent();
            //          Test Camera               
            DsDevice[] device = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            int deviceindex = 0;
            foreach (DirectShowLib.DsDevice _cam in device)
            {
                ListofCamera.Add(new KeyValuePair<int, string>(deviceindex, _cam.Name));
                deviceindex++;
            }
            ChooseCameraComboBox.DataSource = null;
            ChooseCameraComboBox.Items.Clear();

            ChooseCameraComboBox.DataSource = new BindingSource(ListofCamera, null);
            ChooseCameraComboBox.DisplayMember = "Value";
            ChooseCameraComboBox.ValueMember = "Key";

            if (device.Count() == 0)
            {
                MessageBox.Show("Can't find any Camera on this Device\nPlease plugin some of Camera Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Photographtool.Enabled = false;
            }

            // Take list of faces and ID to compare
            List<string> FaceTrainLocation = new List<string>();
            if (data.TakeListIDandListImage(IDofPerson, FaceTrainLocation))
            {
                for (int i = 0; i < FaceTrainLocation.Count; i++)
                {
                    FaceTrainedFolder.Add(new Image<Gray, byte>(Application.StartupPath + FaceTrainLocation[i]));
                }

                faceRecognizer = new EigenFaceRecognizer(FaceTrainedFolder.Count, 1000);
            }
            else
            {
                MessageBox.Show("No Face in Database........", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Main Panel Function
        private void FaceRecognizeTool_Click(object sender, EventArgs e)
        {
            ResetPanel();
            panelFaceRecognize.Visible = true;
            ScreenShow.BackgroundImage = null;
            Application.Idle += FaceRecognizeCameraShow;
        }

        private void Photographtool_Click(object sender, EventArgs e)
        {
            ResetPanel();
            panelPhotograph.Visible = true;
        }

        private void EditPictureTool_Click(object sender, EventArgs e)
        {
            ResetPanel();
            panelEditPicture.Visible = true;
            Application.Idle -= FaceRecognizeCameraShow;
            Application.Idle -= Camerashow;
            ScreenShow.Image = null;
            ScreenShow.BackgroundImage = global::FaceDetectionApp.Properties.Resources.Camerabackground;

        }
        #endregion

        #region MainButton
        //Login button
        private void Signin_Click(object sender, EventArgs e)
        {
            ResetPanel();
            panelLogin.Visible = true;
        }

        //View User Profile Button
        private void ViewProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(login, login, ref IDtoEditProfile);
            profile.ShowDialog();

            if (profile.edit == true)
            {
                ResetPanel();
                panelEditProfile.Visible = true;
            }
        }

        #endregion

        #region Panel Source Code
        //For signup and signin
        #region Sign In      
        
        private void LoginCamera(object sender, EventArgs e)
        {

        }   
        
        private void GuestButton_Click(object sender, EventArgs e)
        {
            ResetPanel();
        }

        private void LoginSubmit_Click(object sender, EventArgs e)
        {
            if (data.LoginWithPass(ref login, LoginIDTextbox.Text, LoginPasswordTextbox.Text) == true)
            {
                ResetPanel();
                LoginIDTextbox.Text = null;
                LoginPasswordTextbox.Text = null;
                LoginIncorrectWarning.Visible = false;
                if (login == 1)
                {
                    Borderform1.BackColor = Color.Red;
                    Borderform2.BackColor = Color.Red;
                    Borderform3.BackColor = Color.Red;
                    Mainscreen.BackColor = Color.Red;
                    Border_Tool.BackColor = Color.Red;
                    Border_Screen.BackColor = Color.Red;
                    ScreenShowBorder.BackColor = Color.Red;
                    // Funtion button
                    EditPictureTool.BackColor = Color.Red;
                    EditPictureTool.ForeColor = Color.White;
                    FaceRecognizeTool.BackColor = Color.Red;
                    FaceRecognizeTool.ForeColor = Color.White;
                    Photographtool.BackColor = Color.Red;
                    Photographtool.ForeColor = Color.White;
                    ChooseCameraComboBox.BackColor = Color.Red;
                    ChooseCameraComboBox.ForeColor = Color.White;
                    //Tool Button
                    RefreshCamera.BackColor = Color.Red;
                    TakePhoto.BackColor = Color.Red;
                    ViewPictures.BackColor = Color.Red;
                    ViewProfile.BackColor = Color.Red;
                    Signin.BackColor = Color.Red;
                    RefreshCamera.BackgroundImage = global::FaceDetectionApp.Properties.Resources.refreshbuttonAdmin;
                    TakePhoto.BackgroundImage = global::FaceDetectionApp.Properties.Resources.photocameraAdmin;
                    ViewPictures.BackgroundImage = global::FaceDetectionApp.Properties.Resources.picturegalleryAdmin;
                    ViewProfile.BackgroundImage = global::FaceDetectionApp.Properties.Resources.profileAdmin;
                    Signin.BackgroundImage = global::FaceDetectionApp.Properties.Resources.loginAdmin;
                }
            }
            else
            {
                LoginIncorrectWarning.Visible = true;
            }
        }

        private void LoginActiveCamera_Click(object sender, EventArgs e)
        {
            Application.Idle += LoginCamera;
        }
        #endregion

        #region Sign Up
        private void panelSignUp_VisibleChanged(object sender, EventArgs e)
        {
            SignUpConfirmPassTextbox.Text = null;
            SignUpUserNametextBox.Text = null;
            SignUpNameTextbox.Text = null;
            SignUpPassTextbox.Text = null;
            SignUpDescriptionTextBox.Text = null;
            SignUpFaceTrained.Image = null;
            SignUpBirthdayPicker.Value = DateTime.Today.AddDays(0);
            SignUpAccountPanel.Visible = true;
            SignUpAccountPanel.Visible = true;
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            ResetPanel();
            panelSignUp.Visible = true;
            p.Image = null;
            Application.Idle += FaceRecognizeCameraShow;
        }

        private void SignUpTrainfaceButton_Click(object sender, EventArgs e)
        {
            if (faces != null)
            {
                trainface = grayim.ToImage<Gray, byte>();
                foreach (var item in faces)
                {
                    trainface = trainface.Copy(item).Resize(100, 100, Inter.Cubic);
                }
                SignUpFaceTrained.Image = trainface.Bitmap;
            }
        }

        private void SignUpResetfaceBt_Click(object sender, EventArgs e)
        {
            SignUpFaceTrained.Image = null;
            trainface = null;
        }

        private void TakePersonPicture_Click(object sender, EventArgs e)
        {
            if (p.Visible == false)
            {
                Application.Idle -= FaceRecognizeCameraShow;
                p.Visible = true;
                p.Image = ScreenShow.Image.Bitmap;
                SignUpTakePersonPicture.BackColor = Color.Red;
            }
            else if (p.Visible == true)
            {
                Application.Idle += FaceRecognizeCameraShow;
                p.Visible = false;
                p.Image = null;
                SignUpTakePersonPicture.BackColor = Color.Black;
            }
        }

        private void SignUpCancel_Click(object sender, EventArgs e)
        {
            trainface = null;
            SignUpNameTextbox.Text = null;
            SignUpPassTextbox.Text = null;
            SignUpConfirmPassTextbox.Text = null;
            SignUpDescriptionTextBox.Text = null;
            SignUpBirthdayPicker.Text = null;
            ResetPanel();
        }

        private void SignUpSubmit_Click(object sender, EventArgs e)
        {
            string lastidtosaveimage = data.TakelastID();
            string localfacetrain, localpersonimg;
            localfacetrain = "\\Data\\FaceTrained\\" + lastidtosaveimage + ".bmp";
            localpersonimg = "\\Data\\PersonalImage\\" + lastidtosaveimage + ".png";
            bool checkinformation = false;
            if (trainface == null)
            {
                checkinformation = false;
                MessageBox.Show("Please Training your face before Submit", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (p.Image == null)
                {
                    checkinformation = false;
                    MessageBox.Show("You don't have Image to save", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(SignUpNameTextbox.Text))
                    {
                        //User
                        if (!string.IsNullOrWhiteSpace(SignUpUserNametextBox.Text))
                        {
                            if (data.CheckUserName(SignUpUserNametextBox.Text) == true)
                            {
                                if (!string.IsNullOrWhiteSpace(SignUpPassTextbox.Text))
                                {
                                    if (string.Equals(SignUpPassTextbox.Text, SignUpConfirmPassTextbox.Text) == true)
                                    {
                                        //Add face and image

                                        trainface.Bitmap.Save(Application.StartupPath + localfacetrain, ImageFormat.Bmp);
                                        p.Image.Save(Application.StartupPath + localpersonimg, ImageFormat.Png);
                                        data.AddPersonToUse(SignUpNameTextbox.Text, SignUpUserNametextBox.Text, SignUpPassTextbox.Text, SignUpBirthdayPicker.Value.ToShortDateString().ToString(), SignUpDescriptionTextBox.Text, localpersonimg, localfacetrain);
                                        MessageBox.Show("Complete addition person to train", "Completed", MessageBoxButtons.OK, MessageBoxIcon.None);
                                        checkinformation = true;
                                    }
                                    else
                                    {
                                        checkinformation = false;
                                        MessageBox.Show("Your Password and Confirmed Password incorrected", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    checkinformation = false;
                                    MessageBox.Show("Your Password incorrected", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                checkinformation = false;
                                MessageBox.Show("Your UserName have already used", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //        //None User

                            //        //Add picture

                            trainface.Bitmap.Save(Application.StartupPath + localfacetrain, ImageFormat.Bmp);
                            p.Image.Save(Application.StartupPath + localpersonimg, ImageFormat.Png);

                            data.AddPerson(SignUpNameTextbox.Text, SignUpBirthdayPicker.Value.ToShortDateString().ToString(), SignUpDescriptionTextBox.Text, localpersonimg, localfacetrain);
                            MessageBox.Show("Complete addition person to train", "Completed", MessageBoxButtons.OK, MessageBoxIcon.None);
                            checkinformation = true;
                        }

                    }
                    else
                    {
                        checkinformation = false;
                        MessageBox.Show("Please write your Name", "Submit ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (checkinformation == true)
            {
                p.Image = null;
                p.Visible = false;
                ResetPanel();
                Application.Idle += FaceRecognizeCameraShow;
            }


            //    //DateTime dateTime = SignUpBirthdayPicker.Value;
            //    //SignUpDescriptionTextBox.Text = dateTime.ToShortDateString().ToString();
            //}
        }

        #endregion

        #region Edit Profile
        private void panelEditProfile_VisibleChanged(object sender, EventArgs e)
        {
            EditProfiledateTimePicker.Value = DateTime.Today.AddDays(0);
            EditProfileNameTextbox.Text = null;
            EditProfileDescriptionTextBox.Text = null;
            p.Image = null;
            EditProfileGrayFaceTrained.Image = null;
            SignUpAccountPanel.Visible = false;
            trainface = null;            

            if (panelEditProfile.Visible == true)
            {
                data.ShowPersonProfile(IDtoEditProfile, ref EP_NameHuman, ref EP_UserName, ref EP_BirthdayHuman, ref EP_DescriptionHuman, ref EP_PersonalImageLocation, ref EP_FaceTrainedLocation);                
                if (IDtoEditProfile == 0 || IDtoEditProfile == 1)
                {
                    EditProfileBirtdayLabel.Visible = false;
                    EditProfiledateTimePicker.Visible = false;
                    EditProfileTrainedFaceButton.Enabled = false;
                    EditProfileChangePictureButton.Enabled = false;
                    EditProfileUserNameTextBox.Text = EP_UserName;
                    EditProfileNameTextbox.Text = EP_NameHuman;
                    EditProfileDescriptionTextBox.Text = EP_DescriptionHuman;
                }
                else
                {
                    EditProfileBirtdayLabel.Visible = true;
                    EditProfiledateTimePicker.Visible = true;
                    EditProfileTrainedFaceButton.Enabled = true;
                    EditProfileChangePictureButton.Enabled = true;
                    EditProfileUserNameTextBox.Text = EP_UserName;
                    EditProfileNameTextbox.Text = EP_NameHuman;
                    EditProfileDescriptionTextBox.Text = EP_DescriptionHuman;
                    EditProfiledateTimePicker.Value = Convert.ToDateTime(EP_BirthdayHuman);
                }                                
                Application.Idle += FaceRecognizeCameraShow;
            }
        }

        private void EditProfileChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(IDtoEditProfile);
            change.Show();
        }

        private void EditProfileChangePictureButton_Click(object sender, EventArgs e)
        {
            if (p.Image == null)
            {
                Application.Idle -= Camerashow;
                EditProfileChangePictureButton.Text = "Reset";
                p.Visible = true;
                p.Image = ScreenShow.Image.Bitmap;
            }
            else if (p.Image != null)
            {
                p.Image = null;
                p.Visible = false;
                EditProfileChangePictureButton.Text = "Take Picture";
                Application.Idle += Camerashow;
            }
        }

        private void EditProfileTrainedFaceButton_Click(object sender, EventArgs e)
        {
            if (EditProfileTrainedFaceButton.Image == null)
            {
                trainface = grayim.ToImage<Gray, byte>();
                foreach (var item in faces)
                {
                    trainface = trainface.Copy(item).Resize(100, 100, Inter.Cubic);
                }
                EditProfileGrayFaceTrained.Image = trainface.Bitmap;
            }
            else if(EditProfileGrayFaceTrained.Image != null)
            {
                //Old Face                
                EditProfileGrayFaceTrained.Image = new Image<Bgr, byte>(Application.StartupPath + EP_FaceTrainedLocation).Bitmap;
            }
        }

        private void EditProfileSubmit_Click(object sender, EventArgs e)
        {
            if (IDtoEditProfile == 0 || IDtoEditProfile == 1)
            {
                data.EditPerson(IDtoEditProfile, EditProfileNameTextbox.Text, EditProfileUserNameTextBox.Text, EditProfileDescriptionTextBox.Text);
                MessageBox.Show("You update this person success", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                ResetPanel();
            }
            else
            {
                if (p.Image!=null)
                {
                    p.Image.Save(Application.StartupPath + EP_PersonalImageLocation,ImageFormat.Png);
                }
                if (EditProfileGrayFaceTrained.Image != null)
                {
                    EditProfileGrayFaceTrained.Image.Save(Application.StartupPath + EP_FaceTrainedLocation, ImageFormat.Bmp);
                }
                data.EditPerson(IDtoEditProfile, EditProfileNameTextbox.Text, EditProfileUserNameTextBox.Text, EditProfiledateTimePicker.Value.ToShortDateString(), EditProfileDescriptionTextBox.Text);
                MessageBox.Show("You update this person success", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                ResetPanel();
            }            
        }

        private void EditProfileNeonCancelButton_Click(object sender, EventArgs e)
        {            
            ResetPanel();
        }
        #endregion

        #region Photograph
        private void Camerashow(object sender, EventArgs arg)
        {
            ScreenShow.Image = capture.QuerySmallFrame();
        }
        #endregion

        #region Edit Picture
        private void btnBrightness_Click(object sender, EventArgs e)
        {
            Brightness f = new Brightness();
            f.Show();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            Resize f = new Resize();
            f.Show();
        }

        private void btnCropping_Click(object sender, EventArgs e)
        {
            Crop f = new Crop();
            f.Show();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            Edit f = new Edit();
            f.Show();
        }





        #endregion

        #region Face Recognize
        public void FaceRecognizeCameraShow(object sender, EventArgs arg)
        {            
            capture.Read(CameratoImage);
            DetectFace();
            foreach (var face in faces)
            {
                Image<Gray, byte> grayface = grayim.ToImage<Gray, byte>();
                grayface = grayface.Copy(face).Resize(100, 100, Inter.Cubic);    //Face of human rescale to 100 x 100                

                if (FaceTrainedFolder.Count != 0)
                {

                    faceRecognizer.Train<Gray, byte>(FaceTrainedFolder.ToArray(), IDofPerson.ToArray());
                    EigenFaceRecognizer.PredictionResult result = faceRecognizer.Predict(grayface);
                    string name;
                    if (result.Label == -1)
                    {
                        name = "Guest";
                    }
                    else
                    {
                        //button
                        bool add = false;
                        if (Recognized.Count == 0)
                        {
                            add = true;
                            Recognized.Add(result.Label);
                        }
                        else
                        {
                            foreach (var item in Recognized)
                            {
                                if (item == result.Label)
                                {
                                    add = false;
                                    break;
                                }
                                else
                                {
                                    Recognized.Add(result.Label);
                                    add = true;
                                }
                            }
                        }

                        if (add == true)
                        {
                            PictureButton button = new PictureButton(login, result.Label);
                            FaceRecognizeShowPersonPanel.Controls.Add(button);
                        }

                        //detect
                        name = data.TakeNameonID(result.Label);
                    }

                    CvInvoke.PutText(DrawtoCamera, name, new Point(face.X + face.Width / 2, face.Y), FontFace.HersheyScriptSimplex, 0.5d, new MCvScalar(176, 248, 0));
                    // Get into button information

                }

            }
            ScreenShow.Image = DrawtoCamera;
        }


        #endregion

        #endregion

        #region Function Extentions
        private void ResetPanel()
        {
            panelFaceRecognize.Visible = false;
            panelPhotograph.Visible = false;
            panelEditPicture.Visible = false;
            panelLogin.Visible = false;            
            panelEditProfile.Visible = false;
            panelSignUp.Visible = false;
          
        }

        // Face Detection and Draw
        private void DetectFaceDraw(Rectangle face)
        {
            CvInvoke.Ellipse(DrawtoCamera, new RotatedRect(new PointF(face.X + face.Width / 2, face.Y + face.Height / 2), new SizeF(face.Width + 20, face.Height + 20), 0), new MCvScalar(176, 248, 0), 3);
            //CvInvoke.Rectangle(v, face, new MCvScalar(176,248,0),3);      //use for rectangle round the face
        }

        private void DetectFace()
        {
            CvInvoke.Resize(CameratoImage, DrawtoCamera, new Size(320, 240));   //Resize camera smaller           
            CvInvoke.CvtColor(DrawtoCamera, grayim, ColorConversion.Bgr2Gray);  //Convert camera to grayscale
            faces = cascade.DetectMultiScale(grayim, 1.1, 10, Size.Empty);      //Face detection            
        }

        //Other function
        

        private void ChooseCameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> SelectItem = (KeyValuePair<int, string>)ChooseCameraComboBox.SelectedItem;
            indexofCamera = SelectItem.Key;
            capture.Dispose();
            capture = new VideoCapture(indexofCamera);
        }




        #endregion

        
    }
}

