using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class GradeAdd : Form
    {

        DatabaseConnect db = new DatabaseConnect();

        string[] gradeCode = new string[100];
        string[] gradeSubject = new string[100];

        public GradeAdd()
        {
            InitializeComponent();
            
        }


        public string TextNumber
        {
            set { this.txtNumber.Text = value; }
        }

        public string TextGrade
        {
            set { this.txtGrade.Text = value; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void GradeAdd_Load(object sender, EventArgs e)
        {
            this.cbSemester.Items.Add("1학기");
            this.cbSemester.Items.Add("2학기");
            this.cbSemester.SelectedIndex = 0;
        }

        private void InsertData()
        {
            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = "";

                    string number = "";
                    string grade = "";
                    string semester = "";
                    string gradecode = "";
                    string gradeSubject2 = "";

                    number = this.txtNumber.Text;
                    grade = this.txtGrade.Text;
                    semester = this.cbSemester.SelectedItem.ToString();
                    gradeSubject2 = this.cbSubject.SelectedItem.ToString();

                    int i = 0;


                    while(true)
                    {
                        if (gradeSubject[i] == gradeSubject2)
                        {
                            break;
                        }

                        i++;
                    }


                    gradecode = gradeCode[i];

                    sql = String.Format("insert into course (coursenum, coursecode, coursegrade, coursesemester) values('{0}', '{1}', '{2}', '{3}')", number, gradecode, grade, semester);


                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    if(command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 처리되었습니다.");
                    }

                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateData()
        {
            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = "";

                    sql = String.Format("select subjectcode, subjectname from subject WHERE subjectsemester = '{0}'", this.cbSemester.SelectedItem.ToString());


                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    int len = 0;

                    

                    while (reader.Read())
                    {
                        gradeCode[len] = reader["subjectcode"].ToString();
                        gradeSubject[len] = reader["subjectname"].ToString();

                        len++;
                    }

                    reader.Close();

                    for(int i = 0; i < len; i++)
                    {
                        cbSubject.Items.Add(gradeSubject[i]);
                    }
                    
                    

                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbSubject.Items.Clear();
            UpdateData();
        }
    }
}
