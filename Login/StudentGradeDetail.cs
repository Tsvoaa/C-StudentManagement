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
    public partial class StudentGradeDetail : Form
    {
        DatabaseConnect db = new DatabaseConnect();

        public StudentGradeDetail()
        {
            InitializeComponent();
        }
        public string TextGrade
        {
            set { this.txtGrade.Text = value; }
        }

        public string TextGradeScore
        {
            set { this.txtGradeScore.Text = value; }
        }

        public string TextProfessor
        {
            set { this.txtProfessor.Text = value; }
        }

        public string TextStudentNum
        {
            set { this.txtStudentNum.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentSubjectLoad()
        {
            try
            {
                String sql = "";

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string subjectName = this.txtGrade.Text;

                    sql = String.Format("SELECT subjectcode, subjectround FROM subject WHERE subjectname = '{0}'", subjectName);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    string subjectCode = reader["subjectcode"].ToString();
                    string subjectRound = reader["subjectround"].ToString();
                    string studentNum = this.txtStudentNum.Text;

                    reader.Close();

                    sql = String.Format("SELECT coursetask, coursemidterm, coursefinalterm FROM course WHERE coursecode = '{0}' AND coursenum = '{1}'", subjectCode, studentNum);

                    command = new MySqlCommand(sql, mysql);
                    reader = command.ExecuteReader();

                    reader.Read();

                    int courseTask = int.Parse(reader["coursetask"].ToString());
                    int courseMidTerm = int.Parse(reader["coursemidterm"].ToString());
                    int courseFinalTerm = int.Parse(reader["coursefinalterm"].ToString());

                    reader.Close();

                    this.txtRound.Text = subjectRound;
                    this.txtTask.Text = Convert.ToString(courseTask);
                    this.txtMidTerm.Text = Convert.ToString(courseMidTerm);
                    this.txtFinalTerm.Text = Convert.ToString(courseFinalTerm);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentGradeDetail_Load(object sender, EventArgs e)
        {
            StudentSubjectLoad();
        }

        private void txtFinalTerm_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseDataSave()
        {
            string StudentNum = this.txtStudentNum.Text;
            string CourseMidTerm = this.txtMidTerm.Text;
            string CourseFinalTerm = this.txtFinalTerm.Text;
            string CourseTask = this.txtTask.Text;
            string subjectName = this.txtGrade.Text;
            string courseScore = this.cbStudentScore.SelectedItem.ToString();

            try
            {

                string sql = "";

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("SELECT subjectcode FROM subject WHERE subjectname = '{0}'", subjectName);
                    
                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();


                    reader.Read();

                    string subjectCode = reader["subjectcode"].ToString();

                    reader.Close();

                    sql = String.Format("UPDATE course SET coursemidterm = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", Convert.ToString(CourseMidTerm), subjectCode, StudentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 1), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursefinalterm = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", Convert.ToString(CourseFinalTerm), subjectCode, StudentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 2), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursetask = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", Convert.ToString(CourseTask), subjectCode, StudentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 3), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursescore = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", courseScore, subjectCode, StudentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 4), "알림");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("정상적으로 처리되었습니다.", "알림");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CourseDataSave();
        }
    }
}
