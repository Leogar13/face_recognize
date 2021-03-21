using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;

namespace FaceDetectionApp
{
    class DataConnect
    {
        SQLiteConnection SQLite = new SQLiteConnection("Data Source=DataProject.db; Version=3;");
        SQLiteCommand liteCommand; 
        
        private string AdditionChar(string directionstring)
        {
            var equal = new StringBuilder();
            foreach (var item in directionstring)
            {
                equal.Append(item);
                if (item=='\\')
                {
                    equal.Append("\\");
                }
                if (item == '\'' )
                {
                    equal.Append("''");
                }
            }
            return equal.ToString();
        }
        
        //private bool CheckComplete(string Text)
        //{
        //    string.Compare()
        //}

        public bool TakeListIDandListImage(List<int> IDofPerson, List<string> ImageLocation)
        {
            SQLite.Open();
            liteCommand = new SQLiteCommand("Select Count(IDHuman) As Count from Human", SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataReader reader = liteCommand.ExecuteReader();
            string equal;
            reader.Read();
            equal = reader["Count"].ToString();
            reader.Close();
            int count = Convert.ToInt32(equal);
            if (count < 2)
            {
                liteCommand = new SQLiteCommand("DELETE FROM Human;     DELETE FROM sqlite_sequence WHERE name = 'Human'; ", SQLite);
                liteCommand.ExecuteNonQuery();
                liteCommand = new SQLiteCommand("INSERT INTO Human (UserName,Password,FaceTrainedLocation,ImagePersonalLocation,Description,Birthday,Name,IDHuman)VALUES('Guest',NULL,NULL,'\\Data\\PersonalImage\\0.png','Well Come to the future!!! You just use this App in Guest',NULL,'Guest',0); ", SQLite);
                liteCommand.ExecuteNonQuery();
                liteCommand = new SQLiteCommand("INSERT INTO Human (UserName,Password,FaceTrainedLocation,ImagePersonalLocation,Description,Birthday,Name,IDHuman)VALUES('Admin','Administrator',NULL,'\\Data\\PersonalImage\\1.png','Well Come Home! My Master...',NULL,'Admin',1); ", SQLite);
                liteCommand.ExecuteNonQuery();
                SQLite.Close();
                return false;
            }            
            else
            {                
                liteCommand = new SQLiteCommand("Select IDHuman,FaceTrainedLocation from Human where IDHuman > 1", SQLite);
                liteCommand.ExecuteNonQuery();
                DataTable table = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(liteCommand);
                adapter.Fill(table);
                adapter.Dispose();
                SQLite.Close();

                if (table.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    int numberrow = 0;
                    while (table.Rows.Count > numberrow)
                    {
                        IDofPerson.Add(Convert.ToInt32(table.Rows[numberrow]["IDHuman"].ToString()));
                        ImageLocation.Add(table.Rows[numberrow]["FaceTrainedLocation"].ToString());
                        numberrow++;
                    }
                    return true;
                }
                
            }
            
            
        }

        public string TakeNameonID(int label)
        {
            SQLite.Open();
            string name;
            liteCommand = new SQLiteCommand("Select Name from Human Where IDHuman=" + label.ToString(), SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataReader reader = liteCommand.ExecuteReader();            
            reader.Read();
            name = reader["Name"].ToString();
            reader.Close();
            SQLite.Close();
            return name;
        }

        public string TakelastID()
        {
            SQLite.Open();
            string sql = "Select Max(IDHuman) As MAX From Human";
            liteCommand=new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();

            SQLiteDataReader reader = liteCommand.ExecuteReader();
            string equal;
            reader.Read();            
            equal = reader["MAX"].ToString();
            reader.Close();
            SQLite.Close();
            var plus = Convert.ToInt32(equal);
            plus++;
            equal = Convert.ToString(plus);                                                                
            return equal;            
        }

        public bool CheckUserName(string UN)
        {
            SQLite.Open();
            string sql = "Select Count(IDHuman) as Count From Human Where UserName = '" + UN + "'";
            liteCommand = new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataReader reader = liteCommand.ExecuteReader();
            reader.Read();
            string equal = reader["Count"].ToString();
            reader.Close();
            var plus = Convert.ToInt32(equal);
            SQLite.Close();
            if (plus == 0)
            {
                return true;
            }
            else
            {
                return false;
            }            

        }

        public void AddPersonToUse(string Name, string UserName, string Password, string Birthday, string Description, string PersonalImageLocation, string FaceTrainedLoaction)
        {            
            SQLite.Open();
            PersonalImageLocation = AdditionChar(PersonalImageLocation);
            FaceTrainedLoaction = AdditionChar(FaceTrainedLoaction);
            string sql = "Insert into Human (Name,Birthday,Description,ImagePersonalLocation,FaceTrainedLocation,Password,UserName) Values " + "('" + Name +"','" + Birthday + "','" + Description + "','" + PersonalImageLocation + "','" + FaceTrainedLoaction + "','" + Password + "','" + UserName + "');";
            liteCommand = new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();

            SQLite.Close();
        }

        public void AddPerson(string Name, string Birthday, string Description, string PersonalImageLocation, string FaceTrainedLoaction)
        {            
            SQLite.Open();
            PersonalImageLocation = AdditionChar(PersonalImageLocation);
            FaceTrainedLoaction = AdditionChar(FaceTrainedLoaction);
            string sql = "Insert into Human (Name,Birthday,Description,ImagePersonalLocation,FaceTrainedLocation) Values " + "('" + Name + "','" + Birthday + "','" + Description + "','" + PersonalImageLocation + "','" + FaceTrainedLoaction + "')";
            liteCommand = new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();
            SQLite.Close();
        }

        public bool LoginWithPass(ref int loginid, string username, string Password)
        {
            SQLite.Open();
            string sql = "Select IDHuman,Password From Human Where UserName =" + "'" + username + "'";
            liteCommand = new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(liteCommand);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            SQLite.Close();
            if(ds.Rows.Count == 0)
            {
                return false;
            }
            if (string.Equals(ds.Rows[0]["Password"].ToString(), Password)==true)
            {
                loginid = Convert.ToInt32(ds.Rows[0]["IDHuman"].ToString());
                return true;
            }
            else
            {
                return false;
            }
            //if (ds.Rows[0]["Password"].ToString() == Password)
            //{                
            //    return true;                
            //}
            //else
            //{                
            //    return false;                
            //}
            
        }

        public void ShowAllPerson()
        {
            SQLite.Open();
            liteCommand = new SQLiteCommand("Select * from ", SQLite);
            liteCommand.ExecuteNonQuery();
            SQLite.Close();
        }

        public void EditPerson(int id, string name, string username, string birthday, string description)
        {
            SQLite.Open();
            liteCommand = new SQLiteCommand("Update Human Set Name ='"+ name + "',Birthday ='" + birthday +"', Description = '" + description + "', UserName = '" + username + "' Where IDHuman = " + id.ToString(),SQLite);
            liteCommand.ExecuteNonQuery();
            SQLite.Close();
        }

        public void EditPerson(int id, string name, string username, string description)
        {
            SQLite.Open();
            liteCommand = new SQLiteCommand("Update Human Set Name ='" + name + "', Description = '" + description + "', UserName = '" + username + "' Where IDHuman = " + id.ToString(), SQLite);
            liteCommand.ExecuteNonQuery();
            SQLite.Close();
        }        

        public bool getsetPass(int id, string pass, string newpass)
        {
            SQLite.Open();
            liteCommand = new SQLiteCommand("Select Password From Human Where IDHuman = " + id.ToString(), SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataReader reader = liteCommand.ExecuteReader();
            reader.Read();
            string equal = reader["Password"].ToString();
            reader.Close();
            
            if (string.Equals(pass,equal) == true)
            {
                liteCommand = new SQLiteCommand("Update Human Set Password = '" + newpass + "' Where IDHuman = " + id.ToString(), SQLite);
                liteCommand.ExecuteNonQuery();
                SQLite.Close();
                return true;
            }
            else
            {
                SQLite.Close();
                return false;
            }
        }

        public void DelPerson()
        {

        }

        public void ShowPersonProfile(int ID, ref string Name, ref string Username, ref string Birthday, ref string Description, ref string PersonalImageLocation, ref string FaceTrainedLocation)
        {
            SQLite.Open();
            
            string sql = "Select Name,Birthday,Description,ImagePersonalLocation,FaceTrainedLocation,UserName From Human Where IDHuman=" + ID;
            liteCommand = new SQLiteCommand(sql, SQLite);
            liteCommand.ExecuteNonQuery();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(liteCommand);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            Name = ds.Rows[0]["Name"].ToString();
            Birthday = ds.Rows[0]["Birthday"].ToString();
            Username = ds.Rows[0]["UserName"].ToString();
            Description = ds.Rows[0]["Description"].ToString();
            PersonalImageLocation = ds.Rows[0]["ImagePersonalLocation"].ToString();
            FaceTrainedLocation = ds.Rows[0]["FaceTrainedLocation"].ToString();

            SQLite.Close();
        }
    }
}
