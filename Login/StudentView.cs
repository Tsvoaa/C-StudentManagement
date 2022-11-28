using Login;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{

    public partial class StudentForm : Form
    {
        // 학년과 반을 저장하기 위한 변수
        int gradeNum = 0;
        int classNum = 0;

        DatabaseConnect db = new DatabaseConnect();



        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            SelectStudent(gradeNum, classNum);
            
        }

        // ListView에 학생들을 추가하는 함수
        private void SelectStudent(int g, int c)
        {
            // ListView에 아이템을 추가하기 전 초기화
            this.lvStudent.Items.Clear();

            // 데이터 저장을 위한 배열 선언
            string[] grade = new string[300];
            string[] classes = new string[300];
            string[] stdNum = new string[300];
            string[] name = new string[300];
            string[] semester = new string[300];

            string sql = "";
            string query = "";

            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    // 각 조건에 맞는 SQL 쿼리문 작성
                    if(g == 0)
                    {
                        query = "Select * from student";
                     
                        if(c == 1)
                        {
                            query += " where stdclass='1반'"; 
                        }
                        else if(c == 2)
                        {
                            query += " where stdclass='2반'";
                        }
                    }
                    else if(g == 1)
                    {
                        query = "Select * from student where stdgrade='1학년'";
                    }
                    else if(g == 2)
                    {
                        query = "Select * from student where stdgrade='2학년'";
                    }
                    else if(g == 3)
                    {
                        query = "Select * from student where stdgrade='3학년'";
                    }

                    if(c == 1 && g != 0)
                    {
                        query += " and stdclass='1반'";
                    }
                    else if(c == 2 && g != 0)
                    {
                        query += " and stdclass='2반'";
                    }

                    sql = String.Format(query);


                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    int len = 0;

                    // 각 데이터들을 배열에 저장
                    while (reader.Read())
                    {
                        grade[len] = reader["stdgrade"].ToString();
                        classes[len] = reader["stdclass"].ToString();
                        stdNum[len] = reader["stdnum"].ToString();
                        name[len] = reader["stdname"].ToString();
                        semester[len] = reader["stdsemester"].ToString();

                        len++;

                        
                    }

                    reader.Close();

                    //출석률을 표시하는 코드

                    int attend = 0;
                    int late = 0;
                    int absent = 0;

                    int absentCheck = 0;

                    double[] attendCount = new double[len];

                    for(int i =0; i < len; i++)
                    {

                        attend = 0;
                        late = 0;
                        absent = 0;
                        absentCheck = 0;

                        sql = String.Format("SELECT courseattend, courselate, courseabsent FROM course WHERE coursenum = '{0}' AND coursesemester = '{1}' AND coursegrade = '{2}'", stdNum[i], semester[i], grade[i]);

                        command = new MySqlCommand(sql, mysql);

                        reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            attend = int.Parse(reader["courseattend"].ToString());
                            late = int.Parse(reader["courselate"].ToString());
                            absent = int.Parse(reader["courseabsent"].ToString());

                            if(absent > absentCheck)
                            {
                                absentCheck = absent;
                                if(late >= 3)
                                {
                                    absentCheck += late / 3;
                                }
                            }

                        }

                        reader.Close();

                        if(absentCheck != 0)
                        {
                            attendCount[i] = 100.0 - ((double)absentCheck / 16.0 * 100.0);
                        }
                        else
                        {
                            attendCount[i] = 100.0;
                        }

                        // checkAttendCount의 결석횟수를 이용하여 아이템 추가
                        switch (absentCheck)
                        {
                            case 0:
                                {
                                    this.lvStudent.Items.Add(new ListViewItem(new string[] { name[i], stdNum[i], grade[i], classes[i], attendCount[i] + "%" })).BackColor = Color.White;
                                    this.lvStudent.ForeColor = Color.Black;
                                    break;
                                }
                            case 1:
                                {
                                    this.lvStudent.Items.Add(new ListViewItem(new string[] { name[i], stdNum[i], grade[i], classes[i], attendCount[i] + "%" })).BackColor = Color.Yellow;
                                    this.lvStudent.ForeColor = Color.Black;
                                    break;
                                }
                            case 2:
                                {
                                    this.lvStudent.Items.Add(new ListViewItem(new string[] { name[i], stdNum[i], grade[i], classes[i], attendCount[i] + "%" })).BackColor = Color.Orange;
                                    this.lvStudent.ForeColor = Color.Black;
                                    break;
                                }
                            case 3:
                                {
                                    this.lvStudent.Items.Add(new ListViewItem(new string[] { name[i], stdNum[i], grade[i], classes[i], attendCount[i] + "%" })).BackColor = Color.Red;
                                    this.lvStudent.ForeColor = Color.Black;
                                    break;
                                }
                            default:
                                {
                                    this.lvStudent.Items.Add(new ListViewItem(new string[] { name[i], stdNum[i], grade[i], classes[i], attendCount[i] + "%" })).BackColor = Color.Gray;
                                    this.lvStudent.ForeColor = Color.Black;
                                    break;
                                }
                        }

                        attendCount[i] = 0;

                    }

                    


                        
                        
                        

                    

                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       

        private void rbGrade1_CheckedChanged(object sender, EventArgs e)
        {
            gradeNum = 1;
            SelectStudent(gradeNum, classNum);
        }

        private void rbGrade2_CheckedChanged(object sender, EventArgs e)
        {
            gradeNum = 2;
            SelectStudent(gradeNum, classNum);
        }

        private void rbGrade3_CheckedChanged(object sender, EventArgs e)
        {
            gradeNum = 3;
            SelectStudent(gradeNum, classNum);
        }

        private void rbGradeAll_CheckedChanged(object sender, EventArgs e)
        {
            gradeNum = 0;
            SelectStudent(gradeNum, classNum);
        }

        private void rbClassAll_CheckedChanged(object sender, EventArgs e)
        {
            classNum = 0;
            SelectStudent(gradeNum, classNum);
        }

        private void rbClass1_CheckedChanged(object sender, EventArgs e)
        {
            classNum = 1;
            SelectStudent(gradeNum, classNum);
        }

        private void rbClass2_CheckedChanged(object sender, EventArgs e)
        {
            classNum = 2;
            SelectStudent(gradeNum, classNum);
        }

        


        private void lvStudent_DoubleClick(object sender, EventArgs e)
        {
            string itemName = lvStudent.SelectedItems[0].SubItems[0].Text;
            string itemNum = lvStudent.SelectedItems[0].SubItems[1].Text;
            string itemGrade = lvStudent.SelectedItems[0].SubItems[2].Text;
            string itemClass = lvStudent.SelectedItems[0].SubItems[3].Text;

            DetailForm detailForm = new DetailForm();

            detailForm.TextName = itemName;
            detailForm.TextNum = itemNum;
            detailForm.TextGrade = itemGrade;
            detailForm.TextClass = itemClass;

            detailForm.Show();


        }



        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            StudentAdd stdAdd = new StudentAdd();
            stdAdd.ShowDialog();
        }

        private void btnViewGrade_Click(object sender, EventArgs e)
        {
            GradeView grade = new GradeView();
            grade.ShowDialog();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        

    }
}
