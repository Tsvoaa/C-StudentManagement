using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
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
    public partial class DetailForm : Form
    {

        DatabaseConnect db = new DatabaseConnect();

        public DetailForm()
        {
            InitializeComponent();
            
        }

        // 실행이 되어지는 부모 FROM에서 데이터를 가져오기 위한 함수 선언
        public string TextName
        {
            set { this.txtName.Text += value; }
        }

        public string TextNum
        {
            set { this.txtStudentNum.Text += value; }
        }

        public string TextGrade
        {
            set { this.txtGrade.Text += value; }
        }

        public string TextClass
        {
            set { this.txtClass.Text += value; }
        }

        // Form 로드 시 데이터를 가져오는 함수
        private void FirstData()
        {
            this.lvInfo.Items.Clear();

            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string query = "";
                    string sql = "";


                    sql = String.Format("SELECT subjectcode FROM subject WHERE subjectgrade = '{0}' AND subjectsemester = '{1}'", this.cbGrade.SelectedItem.ToString(), this.cbSemester.SelectedItem.ToString());
                    
                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    string[] subjectCode = new string[10];

                    int len2 = 0;

                    while(reader.Read())
                    {
                        subjectCode[len2] = reader["subjectcode"].ToString();

                        len2++;
                    }


                    reader.Close();

                    string[] gradecode = new string[10];
                    int[] attend = new int[10];
                    int[] late = new int[10];
                    int[] absent = new int[10];
                    int[] task = new int[10];
                    int[] midterm = new int[10];
                    int[] finalterm = new int[10];

                    int len = 0;

                    for (int i = 0; i < len2; i++)
                    {
                        // 과목 코드와, 출석 정보를 가져오는 쿼리문
                        query = "select coursecode, courseattend, courselate, courseabsent, coursemidterm, coursefinalterm, coursetask from course where coursenum = '" + txtStudentNum.Text + "'";
                        query += " AND coursecode = '" + subjectCode[i] + "'";

                        sql = String.Format(query);

                        command = new MySqlCommand(sql, mysql);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            gradecode[len] = reader["coursecode"].ToString();
                            attend[len] = int.Parse(reader["courseattend"].ToString());
                            late[len] = int.Parse(reader["courselate"].ToString());
                            absent[len] = int.Parse(reader["courseabsent"].ToString());
                            task[len] = int.Parse(reader["coursetask"].ToString());
                            midterm[len] = int.Parse(reader["coursemidterm"].ToString());
                            finalterm[len] = int.Parse(reader["coursefinalterm"].ToString());

                            len++;
                        }

                        reader.Close();

                    } 

                   

                    string[] gradeSubject = new string[10];
                    int[] gradeScore = new int[10];
                    string[] professor = new string[10];

                    


                    for (int i = 0; i < len; i++)
                    {
                        // 과목명과 학점, 담당교수의 데이터를 가져오는 쿼리문
                        query = "select subjectname, subjectnum, subjectprofessor from subject where subjectcode = '" + gradecode[i] + "'";

                        sql = String.Format(query);

                        command = new MySqlCommand(sql, mysql);

                        reader = command.ExecuteReader();



                        while (reader.Read())
                        {
                            gradeSubject[i] = reader["subjectname"].ToString();
                            gradeScore[i] = int.Parse(reader["subjectnum"].ToString());
                            professor[i] = reader["subjectprofessor"].ToString();
                        }

                        reader.Close();

                    }

                    string str = "";
                    int count = 0;
                    double attendScore = 0.0;


                    // 데이터 삽입을 위한 반복문
                    for (int i = 0; i < len; i++)
                    {
                        count = 0;
                        attendScore = 100.0;

                        if (late[i] >= 3)
                        {
                            count = (late[i] / 3);

                            absent[i] += count;
                        }

                        if (absent[i] != 0)
                        {
                            attendScore = 100.0 - ((double)absent[i] / 16.0 * 100.0);
                        }

                        // 결석한 과목의 배경색 변경을 위한 조건문
                        switch (absent[i])
                        {
                            // 결석 0회 : 흰색 바탕
                            case 0:
                                {
                                    
                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.White;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 1회 : 노란색 바탕
                            case 1:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Yellow;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 2회 : 주황색 바탕
                            case 2:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Orange;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 3회 : 빨간색 바탕
                            case 3:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Red;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 4회 이상 : F : 회색 바탕
                            default:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Gray;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                        }

                    }


                        mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
        // Form 로드 시 작동
        private void DetailForm_Load(object sender, EventArgs e)
        {
            // 각 ComboBox에 학년에 맞는 데이터 삽입
            this.cbSemester.Items.Add("1학기");
            this.cbSemester.Items.Add("2학기");
            this.cbSemester.SelectedIndex = 0;

            if (this.txtGrade.Text == "1학년")
            {
                

                this.cbGrade.Items.Clear();
                this.cbGrade.Items.Add("1학년");
                

                this.cbGrade.SelectedIndex = 0;

                
            }
            else if(this.txtGrade.Text == "2학년")
            {
                this.cbGrade.Items.Clear();
                this.cbGrade.Items.Add("2학년");
                this.cbGrade.Items.Add("1학년");

                this.cbGrade.SelectedIndex = 0;

               
            }
            else if(this.txtGrade.Text == "3학년")
            {
                this.cbGrade.Items.Clear();
                this.cbGrade.Items.Add("3학년");
                this.cbGrade.Items.Add("2학년");
                this.cbGrade.Items.Add("1학년");

                this.cbGrade.SelectedIndex = 0;

                
            }

            // 데이터를 가져오는 함수
            FirstData();

            // 학생 데이터를 가져오는 DB 처리
            StudentData();

        }

        private void StudentData()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = "";
                    string query = "";

                    

                    // 성별과, 군대 정보를 가져오기 위한 쿼리문
                    query = "select stdgender, stdarmy, stdmajor, stdminor from student where stdnum = '" + txtStudentNum.Text + "'";

                    sql = String.Format(query);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    string gender = "";
                    string army = "";
                    int major = 0;
                    int minor = 0;


                    while (reader.Read())
                    {
                        gender = reader["stdgender"].ToString();
                        army = reader["stdarmy"].ToString();
                        major = int.Parse(reader["stdmajor"].ToString());
                        minor = int.Parse(reader["stdminor"].ToString());
                    }

                    reader.Close();

                    sql = String.Format("SELECT count(*) FROM error WHERE errornum = '{0}'", this.txtStudentNum.Text);

                    command = new MySqlCommand(sql, mysql);
                    reader = command.ExecuteReader();

                    int errorCount = 0;

                    reader.Read();

                    errorCount = int.Parse(reader["count(*)"].ToString());

                    reader.Close();


                    this.txtGender.Text = gender;

                    if (army == "T")
                    {
                        this.txtArmy.Text = "군필자";
                    }
                    else if (army == "F")
                    {
                        this.txtArmy.Text = "미필자";
                    }
                    else if (army == "N")
                    {
                        this.txtArmy.Text = "해당없음";
                    }

                    this.txtMajor.Text = Convert.ToString(major);
                    this.txtMinor.Text = Convert.ToString(minor);

                    this.txtComplete.Text = Convert.ToString(major + minor);
                    this.txtGraduration.Text = "108";

                    this.txtError.Text = Convert.ToString(errorCount);

                    mysql.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ComboBox의 데이터 변경 시 실행
        private void GradeData()
        {
            this.lvInfo.Items.Clear();

            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string query = "";
                    string sql = "";


                    sql = String.Format("SELECT subjectcode FROM subject WHERE subjectgrade = '{0}' AND subjectsemester = '{1}'", this.cbGrade.SelectedItem.ToString(), this.cbSemester.SelectedItem.ToString());

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    string[] subjectCode = new string[10];

                    int len2 = 0;

                    while (reader.Read())
                    {
                        subjectCode[len2] = reader["subjectcode"].ToString();

                        len2++;
                    }


                    reader.Close();

                    string[] gradecode = new string[10];
                    int[] attend = new int[10];
                    int[] late = new int[10];
                    int[] absent = new int[10];
                    int[] task = new int[10];
                    int[] midterm = new int[10];
                    int[] finalterm = new int[10];

                    int len = 0;

                    for (int i = 0; i < len2; i++)
                    {
                        // 과목 코드와, 출석 정보, 성적을 가져오는 쿼리문
                        query = "select coursecode, courseattend, courselate, courseabsent, coursemidterm, coursefinalterm, coursetask from course where coursenum = '" + txtStudentNum.Text + "'";
                        query += " AND coursecode = '" + subjectCode[i] + "'";

                        sql = String.Format(query);

                        command = new MySqlCommand(sql, mysql);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            gradecode[len] = reader["coursecode"].ToString();
                            attend[len] = int.Parse(reader["courseattend"].ToString());
                            late[len] = int.Parse(reader["courselate"].ToString());
                            absent[len] = int.Parse(reader["courseabsent"].ToString());
                            midterm[len] = int.Parse(reader["coursemidterm"].ToString());
                            finalterm[len] = int.Parse(reader["coursefinalterm"].ToString());
                            task[len] = int.Parse(reader["coursetask"].ToString());


                            len++;
                        }

                        reader.Close();

                    }



                    string[] gradeSubject = new string[10];
                    int[] gradeScore = new int[10];
                    string[] professor = new string[10];




                    for (int i = 0; i < len; i++)
                    {
                        // 과목명과 학점, 담당교수의 데이터를 가져오는 쿼리문
                        query = "select subjectname, subjectnum, subjectprofessor from subject where subjectcode = '" + gradecode[i] + "'";

                        sql = String.Format(query);

                        command = new MySqlCommand(sql, mysql);

                        reader = command.ExecuteReader();



                        while (reader.Read())
                        {
                            gradeSubject[i] = reader["subjectname"].ToString();
                            gradeScore[i] = int.Parse(reader["subjectnum"].ToString());
                            professor[i] = reader["subjectprofessor"].ToString();
                        }

                        reader.Close();

                    }

                    string str = "";
                    int count = 0;
                    double attendScore = 0.0;

                    //성적입력을 위한 코드

                    


                    // 데이터 삽입을 위한 반복문
                    for (int i = 0; i < len; i++)
                    {
                        count = 0;
                        attendScore = 100.0;

                        if (late[i] >= 3)
                        {
                            count = (late[i] / 3);

                            absent[i] += count;
                        }

                        if (absent[i] != 0)
                        {
                            attendScore = 100.0 - ((double)absent[i] / 16.0 * 100.0);
                        }

                        // 결석한 과목의 배경색 변경을 위한 조건문
                        switch (absent[i])
                        {
                            // 결석 0회 : 흰색 바탕
                            case 0:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.White;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 1회 : 노란색 바탕
                            case 1:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Yellow;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 2회 : 주황색 바탕
                            case 2:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Orange;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 3회 : 빨간색 바탕
                            case 3:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Red;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                            // 결석 4회 이상 : F : 회색 바탕
                            default:
                                {

                                    this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Gray;
                                    this.lvInfo.ForeColor = Color.Black;
                                    break;
                                }
                        }

                    }


                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ComboBox의 데이터 변경 시 실행
        private void SemesterData()
        {
            this.lvInfo.Items.Clear();

            try
            {

                
                    if(this.cbGrade.SelectedItem == null)
                    {

                    }
                    else
                    {
                    using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                    {
                        mysql.Open();

                        string query = "";
                        string sql = "";


                        sql = String.Format("SELECT subjectcode FROM subject WHERE subjectgrade = '{0}' AND subjectsemester = '{1}'", this.cbGrade.SelectedItem.ToString(), this.cbSemester.SelectedItem.ToString());

                        MySqlCommand command = new MySqlCommand(sql, mysql);

                        MySqlDataReader reader = command.ExecuteReader();

                        string[] subjectCode = new string[10];

                        int len2 = 0;

                        while (reader.Read())
                        {
                            subjectCode[len2] = reader["subjectcode"].ToString();

                            len2++;
                        }


                        reader.Close();

                        string[] gradecode = new string[10];
                        int[] attend = new int[10];
                        int[] late = new int[10];
                        int[] absent = new int[10];
                        int[] task = new int[10];
                        int[] midterm = new int[10];
                        int[] finalterm = new int[10];

                        int len = 0;

                        for (int i = 0; i < len2; i++)
                        {
                            // 과목 코드와, 출석 정보를 가져오는 쿼리문
                            query = "select coursecode, courseattend, courselate, courseabsent, coursemidterm, coursefinalterm, coursetask from course where coursenum = '" + txtStudentNum.Text + "'";
                            query += " AND coursecode = '" + subjectCode[i] + "'";

                            sql = String.Format(query);

                            command = new MySqlCommand(sql, mysql);
                            reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                gradecode[len] = reader["coursecode"].ToString();
                                attend[len] = int.Parse(reader["courseattend"].ToString());
                                late[len] = int.Parse(reader["courselate"].ToString());
                                absent[len] = int.Parse(reader["courseabsent"].ToString());
                                midterm[len] = int.Parse(reader["coursemidterm"].ToString());
                                finalterm[len] = int.Parse(reader["coursefinalterm"].ToString());
                                task[len] = int.Parse(reader["coursetask"].ToString());

                                len++;
                            }

                            reader.Close();

                        }



                        string[] gradeSubject = new string[10];
                        int[] gradeScore = new int[10];
                        string[] professor = new string[10];




                        for (int i = 0; i < len; i++)
                        {
                            // 과목명과 학점, 담당교수의 데이터를 가져오는 쿼리문
                            query = "select subjectname, subjectnum, subjectprofessor from subject where subjectcode = '" + gradecode[i] + "'";

                            sql = String.Format(query);

                            command = new MySqlCommand(sql, mysql);

                            reader = command.ExecuteReader();



                            while (reader.Read())
                            {
                                gradeSubject[i] = reader["subjectname"].ToString();
                                gradeScore[i] = int.Parse(reader["subjectnum"].ToString());
                                professor[i] = reader["subjectprofessor"].ToString();
                            }

                            reader.Close();

                        }

                        string str = "";
                        int count = 0;
                        double attendScore = 0.0;


                        // 데이터 삽입을 위한 반복문
                        for (int i = 0; i < len; i++)
                        {
                            count = 0;
                            attendScore = 100.0;

                            if (late[i] >= 3)
                            {
                                count = (late[i] / 3);

                                absent[i] += count;
                            }

                            if (absent[i] != 0)
                            {
                                attendScore = 100.0 - ((double)absent[i] / 16.0 * 100.0);
                            }

                            // 결석한 과목의 배경색 변경을 위한 조건문
                            switch (absent[i])
                            {
                                // 결석 0회 : 흰색 바탕
                                case 0:
                                    {

                                        this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.White;
                                        this.lvInfo.ForeColor = Color.Black;
                                        break;
                                    }
                                // 결석 1회 : 노란색 바탕
                                case 1:
                                    {

                                        this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Yellow;
                                        this.lvInfo.ForeColor = Color.Black;
                                        break;
                                    }
                                // 결석 2회 : 주황색 바탕
                                case 2:
                                    {

                                        this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Orange;
                                        this.lvInfo.ForeColor = Color.Black;
                                        break;
                                    }
                                // 결석 3회 : 빨간색 바탕
                                case 3:
                                    {

                                        this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Red;
                                        this.lvInfo.ForeColor = Color.Black;
                                        break;
                                    }
                                // 결석 4회 이상 : F : 회색 바탕
                                default:
                                    {

                                        this.lvInfo.Items.Add(new ListViewItem(new string[] { gradeSubject[i], String.Format("{0}", gradeScore[i]), professor[i], attendScore.ToString() + "%", Convert.ToString(task[i]), Convert.ToString(midterm[i]), Convert.ToString(finalterm[i]) })).BackColor = Color.Gray;
                                        this.lvInfo.ForeColor = Color.Black;
                                        break;
                                    }
                            }

                        }


                        mysql.Close();
                    }
                }


                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ComboBox : 학년을 변경 시
        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeData();
        }

        // ComboBox : 학기를 변경 시
        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            SemesterData();
        }

        // 과목 추가 버튼을 누를 시 실행
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 과목을 추가할 수 있는 Form을 보여주기
            GradeAdd gradeAdd = new GradeAdd();

            gradeAdd.TextNumber = this.txtStudentNum.Text;
            gradeAdd.TextGrade = this.txtGrade.Text;

            gradeAdd.ShowDialog();


        }

        // ListView의 데이터를 더블클릭 시 실행
        private void lvInfo_DoubleClick(object sender, EventArgs e)
        {
            // 학생이 수강 중인 과목의 세부 정보를 보기 위한 Form 실행
            StudentGradeDetail studentGradeDetail = new StudentGradeDetail();

            studentGradeDetail.TextGrade = this.lvInfo.SelectedItems[0].SubItems[0].Text;
            studentGradeDetail.TextGradeScore = this.lvInfo.SelectedItems[0].SubItems[1].Text;
            studentGradeDetail.TextProfessor = this.lvInfo.SelectedItems[0].SubItems[2].Text;
            studentGradeDetail.TextStudentNum = this.txtStudentNum.Text;
            
            studentGradeDetail.ShowDialog();
        }

        // ListView의 선택된 데이터가 변경될 시 실행
        private void lvInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 오류 방지를 위한 코드
            if(this.lvInfo.SelectedItems.Count == 0)
            {

            }
            else
            {
                this.txtSubject.Text = this.lvInfo.SelectedItems[0].SubItems[0].Text;

                try
                {
                    
                    using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                    {
                        mysql.Open();

                        string sql = "";

                        string gradeSubject = this.txtSubject.Text;

                        // 수업 시수를 가져오기 위한 쿼리문
                        sql = String.Format("select subjectround from subject where subjectname = '{0}'", gradeSubject);


                        MySqlCommand command = new MySqlCommand(sql, mysql);

                        MySqlDataReader reader = command.ExecuteReader();


                        int len = 0;

                        string gradeWeek = "";

                        while (reader.Read())
                        {
                            gradeWeek = reader["subjectround"].ToString();

                            len++;
                        }

                        reader.Close();

                        int week = int.Parse(gradeWeek);
                        int count = 0;

                        // 데이터 지우기
                        this.cbWeek.Items.Clear();

                        //데이터 추가
                        for (int i = 0; i < week; i++)
                        {
                            count = i + 1;
                            this.cbWeek.Items.Add(count);
                        }





                        mysql.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void lblAttend_Click(object sender, EventArgs e)
        {
            string subjectName = this.txtSubject.Text;
            string stdNum = this.txtStudentNum.Text;

            string sql = "";

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("SELECT subjectcode FROM subject WHERE subjectname = '{0}'", subjectName);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    string subjectCode = reader["subjectcode"].ToString();

                    reader.Close();


                    sql = String.Format("SELECT courseattend FROM course WHERE coursecode = '{0}' AND coursenum = '{1}'", subjectCode, stdNum);

                    command = new MySqlCommand(sql, mysql);
                    reader = command.ExecuteReader();

                    reader.Read();

                    int attend = int.Parse(reader["courseattend"].ToString());

                    reader.Close();

                    attend++;

                    sql = String.Format("UPDATE course SET courseattend = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", attend, subjectCode, stdNum);

                    command = new MySqlCommand(sql, mysql);

                    // 성공 여부 검사
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update data.");
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 업데이트 되었습니다.", "알림");
                        GradeData();
                    }

                    mysql.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnNotAttend_Click(object sender, EventArgs e)
        {
            string subjectName = this.txtSubject.Text;
            string stdNum = this.txtStudentNum.Text;

            string sql = "";

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("SELECT subjectcode FROM subject WHERE subjectname = '{0}'", subjectName);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    string subjectCode = reader["subjectcode"].ToString();

                    reader.Close();


                    sql = String.Format("SELECT courseabsent FROM course WHERE coursecode = '{0}' AND coursenum = '{1}'", subjectCode, stdNum);

                    command = new MySqlCommand(sql, mysql);
                    reader = command.ExecuteReader();

                    reader.Read();

                    int absent = int.Parse(reader["courseabsent"].ToString());

                    reader.Close();

                    absent++;

                    sql = String.Format("UPDATE course SET courseabsent = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", absent, subjectCode, stdNum);

                    command = new MySqlCommand(sql, mysql);

                    // 성공 여부 검사
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to update data.");
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 업데이트 되었습니다.", "알림");
                        GradeData();
                    }

                    mysql.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            ErrorView errorView = new ErrorView();

            errorView.TextStudentNum = this.txtStudentNum.Text;
            errorView.TextStudentName = this.txtName.Text;

            errorView.ShowDialog();
        }
    }
}
