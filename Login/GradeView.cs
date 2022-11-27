using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class GradeView : Form
    {
        // DB 연결을 위한 변수 및 값 대입
        DatabaseConnect db = new DatabaseConnect();

        public GradeView()
        {
            InitializeComponent();
            // DB 연결을 위한 사전 설정
            
        }

        private void GradeView_Load(object sender, EventArgs e)
        {
            // 최신 데이터를 가져오는 함수
            UpdateData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGradeName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // 과목을 새로 추가하는 버튼
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtCode.Text != "")
            {
                if(this.txtName.Text != "")
                {
                    if(this.txtScore.Text != "")
                    {
                        // 과목을 추가하는 함수
                        AddData();
                        // 최신 데이터를 가져오는 함수
                        UpdateData();
                    }
                    else
                    {
                        MessageBox.Show("빈칸을 모두 채워주세요!", "알림");
                    }
                }
                else
                {
                    MessageBox.Show("빈칸을 모두 채워주세요!", "알림");
                }
            }
            else
            {
                MessageBox.Show("빈칸을 모두 채워주세요!", "알림");
            }
        }


        // DB에 데이터를 추가하는 함수
        private void AddData()
        {
            try
            {
                // MYSQL 선언
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    // DB open
                    mysql.Open();

                    string sql = "";

                    string subjectCode = this.txtCode.Text;

                    string subjectGrade = this.cbGrade.SelectedItem.ToString();
                    string subjectSemester = this.cbGrade.SelectedItem.ToString();

                    string subjectName = this.txtName.Text;

                    string subjectProfessor = this.txtProfessor.Text;

                    string subjectNum = this.txtScore.Text;
                    string subjectRound = this.txtGradeWeek.Text;

                    // 데이터 삽입을 위한 SQL 쿼리문
                    sql = String.Format("INSERT INTO subject VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", subjectCode, subjectGrade, subjectSemester, subjectName, subjectProfessor, subjectNum, subjectRound);
                  
                    

                    // SQL 쿼리문 실행
                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    // 성공 여부 검사
                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("Failed to insert data.");
                        mysql.Close();

                    }
                    else
                    {
                        MessageBox.Show("정상적으로 추가되었습니다.", "알림");
                        mysql.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 최신 데이터를 가져오는 함수
        private void UpdateData()
        {
            // 데이터를 최신화하기 전 지우기
            this.lvGrade.Items.Clear();

            try
            {
                // MYSQL 선언
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    // DB 오픈
                    mysql.Open();

                    string query = "";
                    string sql = "";

                    // SQL 쿼리문
                    query = "select * from subject";
                    sql = String.Format(query);

                    // SQL 쿼리 실행
                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    // 데이터를 읽어오기 위한 Reader 선언
                    MySqlDataReader reader = command.ExecuteReader();


                    string[] subjectCode = new string[100];
                    string[] subjectName = new string[100];
                    string[] subjectNum = new string[100];
                    string[] subjectRound = new string[100];
                    string[] subjectGrade = new string[100];
                    string[] subjectSemester = new string[100];

                    int len = 0;

                    // 가져온 데이터 갯수만큼 실행
                    while (reader.Read())
                    {
                        // 데이터 대입
                        subjectCode[len] = reader["subjectcode"].ToString();
                        subjectName[len] = reader["subjectname"].ToString();
                        subjectNum[len] = reader["subjectnum"].ToString();
                        subjectRound[len] = reader["subjectround"].ToString();
                        subjectGrade[len] = reader["subjectgrade"].ToString();
                        subjectSemester[len] = reader["subjectsemester"].ToString();

                        len++;
                    }

                    reader.Close();

                    // 데이터 삽입을 위한 쿼리문
                    for (int i = 0; i < len; i++)
                    {
                        this.lvGrade.Items.Add(new ListViewItem(new string[] { subjectCode[i], subjectName[i], subjectNum[i], subjectRound[i], subjectGrade[i], subjectSemester[i] }));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // 과목을 삭제하기 위한 버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // DB의 데이터를 삭제하는 함수
            DeleteData();
            // 최신 데이터를 가져오는 함수
            UpdateData();
        }

        // DB의 데이터를 삭제하는 함수
        private void DeleteData()
        {
            
            if (this.txtGradeCode2.Text != "")
            {
                try
                {
                    // MYSQL 선언
                    using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                    {
                        // MYSQL 오픈
                        mysql.Open();

                        string sql = "";

                        string subjectCode = this.txtGradeCode2.Text;

                        // SQL 쿼리문
                        sql = String.Format("delete from subject where subjectcode = '{0}'", subjectCode);

                        // SQL 쿼리문 실행
                        MySqlCommand command = new MySqlCommand(sql, mysql);

                        // 성공 여부 판단
                        if (command.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("Failed to delete data.");
                            mysql.Close();
                        }
                        else
                        {
                            MessageBox.Show("성공적으로 삭제되었습니다.");

                            mysql.Close();
                        }




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("빈칸을 채워주세요!", "알림");
            }

            
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        // ListView의 데이터를 선택했을 때 실행
        private void lvGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                처음 실행시 정상적으로 this.txtSelectGrade.Text = this.lvGrade.SelectedItems[0].SubItems[1].Text; 이 출력되나
                두번째 선택 시 this.lvGrade.SelectedItems.Count의 값이 0이 됬다가 1이 되어
                    -> 선택이 해제 되었다가 다시 선택이 되어
                SelectedItems[0].SubItems[1]에서 오류가 발생하므로 아래의 조건문이 필요
             */
            if (this.lvGrade.SelectedItems.Count == 0)
            {

            }
            else
            {
                this.txtSelectGrade.Text = this.lvGrade.SelectedItems[0].SubItems[1].Text;

                try
                {
                    // MYSQL 선언
                    using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                    {
                        // MYSQL 오픈
                        mysql.Open();

                        string sql = "";

                        string subjectName = this.txtSelectGrade.Text;

                        //SQL 쿼리문
                        sql = String.Format("select subjectround from subject where subjectname = '{0}'", subjectName);

                        // SQL 쿼리문 실행
                        MySqlCommand command = new MySqlCommand(sql, mysql);

                        // 가져온 데이터를 읽기 위한 Reader 선언
                        MySqlDataReader reader = command.ExecuteReader();


                        int len = 0;

                        string subjectRound = "";

                        // 데이터의 갯수만큼 실행
                        while (reader.Read())
                        {
                            subjectRound = reader["subjectround"].ToString();

                            len++;
                        }

                        
                        reader.Close();

                        int week = int.Parse(subjectRound);
                        int count = 0;

                        // 데이터를 지워주기
                        this.cbSelectWeek.Items.Clear();

                        // 데이터 삽입
                        for (int i = 0; i < week; i++)
                        {
                            count = i + 1;
                            this.cbSelectWeek.Items.Add(count);
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


        // 수강을 하는 학생의 전체 출석을 하기 위한 버튼
        private void btnAttend_Click(object sender, EventArgs e)
        {
            string subjectName = this.txtSelectGrade.Text;
            

            try
            {
                // MYSQL 선언
                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = "";

                   
                    // 과목 코드를 가져오기 위한 쿼리문
                    sql = String.Format("select subjectcode from subject where subjectname = '{0}'", subjectName);


                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();


                    int len = 0;

                    string courseCode = "";

                    while (reader.Read())
                    {
                        courseCode = reader["subjectcode"].ToString();

                        len++;
                    }

                    reader.Close();

                    // 출석정보와 학번을 가져오기 위한 쿼리문
                    sql = String.Format("select courseattend, coursenum from course where coursecode = '{0}'", courseCode);

                    command = new MySqlCommand(sql, mysql);

                    reader = command.ExecuteReader();


                    int[] courseAttend = new int[100];
                    string[] courseNum = new string[100];

                    len = 0;

                    while(reader.Read())
                    {
                        courseAttend[len] = int.Parse(reader["courseattend"].ToString());
                        courseNum[len] = reader["coursenum"].ToString();

                        len++;
                    }

                    reader.Close();

                    string[] attend = new string[16];

                    for (int i = 0; i < len; i++)
                    {
                        courseAttend[i]++;
 
                        // 출석정보를 DB에 업데이트하는 작업
                        //sql = String.Format("update stdsubject set attend = '{0}' where gradecode = '{1}' and number = '[2}'", attendDB[i], gradeCode, numberDB[i]);
                        sql = String.Format("UPDATE course SET courseattend = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", courseAttend[i], courseCode, courseNum[i]);

                        command = new MySqlCommand(sql, mysql);

                        if(command.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", i), "알림");
                        }

                    }

                    MessageBox.Show("정상적으로 처리되었습니다.", "알림");





                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // 수강을 하는 학생의 전체 결석을 하기 위한 버튼
        private void btnNotAttend_Click(object sender, EventArgs e)
        {
            string subjectName = this.txtSelectGrade.Text;


            try
            {

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = "";


                    // 과목코드를 가져오기 위한 쿼리문
                    sql = String.Format("select subjectcode from subject where subjectname = '{0}'", subjectName);


                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();


                    int len = 0;

                    string courseCode = "";

                    while (reader.Read())
                    {
                        courseCode = reader["subjectcode"].ToString();

                        len++;
                    }

                    reader.Close();

                    // 출석정보와 학번을 가져오기 위한 쿼리문
                    sql = String.Format("select courseabsent, coursenum from course where coursecode = '{0}'", courseCode);

                    command = new MySqlCommand(sql, mysql);

                    reader = command.ExecuteReader();


                    int[] courseAbsent = new int[100];
                    string[] courseNum = new string[100];

                    len = 0;

                    while (reader.Read())
                    {
                        courseAbsent[len] = int.Parse(reader["courseabsent"].ToString());
                        courseNum[len] = reader["coursenum"].ToString();

                        len++;
                    }

                    reader.Close();

                    

                    
                    for (int i = 0; i < len; i++)
                    {
                        courseAbsent[i]++;

                        // 출석정보를 업데이트하는 쿼리문
                        //sql = String.Format("update stdsubject set attend = '{0}' where gradecode = '{1}' and number = '[2}'", attendDB[i], gradeCode, numberDB[i]);
                        sql = String.Format("UPDATE course SET courseabsent = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", courseAbsent[i], courseCode, courseNum[i]);

                        command = new MySqlCommand(sql, mysql);

                        if (command.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", i), "알림");
                        }

                    }

                    MessageBox.Show("정상적으로 처리되었습니다.", "알림");





                    mysql.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvGrade_DoubleClick(object sender, EventArgs e)
        {
            GradeViewDetail gradeViewDetail = new GradeViewDetail();

            gradeViewDetail.TextSubjectCode = this.lvGrade.SelectedItems[0].SubItems[0].Text;
            gradeViewDetail.TextSubjectGrade = this.lvGrade.SelectedItems[0].SubItems[4].Text;
            gradeViewDetail.TextSubjectSemester = this.lvGrade.SelectedItems[0].SubItems[5].Text;
            gradeViewDetail.TextSubjectName = this.lvGrade.SelectedItems[0].SubItems[1].Text;


            gradeViewDetail.ShowDialog();
        }
    }
}
