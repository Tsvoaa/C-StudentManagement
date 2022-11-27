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
    public partial class GradeViewDetail : Form
    {
        DatabaseConnect db = new DatabaseConnect();

        public string TextSubjectCode
        {
            set { this.txtSubjectCode.Text = value; }
        }

        public string TextSubjectGrade
        {
            set { this.txtGrade.Text = value; }
        }

        public string TextSubjectSemester
        {
            set { this.txtSemester.Text = value; }
        }

        public string TextSubjectName
        {
            set { this.txtSubjectName.Text = value; }
        }


        public GradeViewDetail()
        {
            InitializeComponent();
        }

        private void CourseStudent()
        {
            string subjectCode = this.txtSubjectCode.Text;

            try
            {
                string sql = "";


                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string studentGrade = this.txtGrade.Text;
                    string studentSemester = this.txtSemester.Text;

                    sql = String.Format("SELECT stdnum FROM student WHERE stdgrade = '{0}'AND stdsemester = '{1}'", studentGrade, studentSemester);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    string[] studentNum = new string[300];

                    int len = 0;

                    while(reader.Read())
                    {
                        studentNum[len] = reader["stdnum"].ToString();

                        len++;
                    }

                    reader.Close();

                    sql = String.Format("SELECT count(*) FROM course WHERE coursecode = '{0}'", subjectCode);

                    command = new MySqlCommand(sql, mysql);

                    reader = command.ExecuteReader();

                    reader.Read();

                    int count = int.Parse(reader["count(*)"].ToString());


                    reader.Close();

                    string[] courseNum = new string[300];
                    int[] courseAttend = new int[300];
                    int[] courseLate = new int[300];
                    int[] courseAbsent = new int[300];
                    int[] courseTask = new int[300];
                    int[] courseMidTerm = new int[300];
                    int[] courseFinalTerm = new int[300];
                    string[] courseScore = new string[300];

                    int len2 = 0;

                    for (int i = 0; i < len; i++)
                    {
                        sql = String.Format("SELECT * FROM course WHERE coursecode = '{0}' AND coursenum = '{1}'", subjectCode, studentNum[i]);

                        command = new MySqlCommand(sql, mysql);
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            courseNum[len2] = reader["coursenum"].ToString();
                            courseAttend[len2] = int.Parse(reader["courseAttend"].ToString());
                            courseLate[len2] = int.Parse(reader["courselate"].ToString());
                            courseAbsent[len2] = int.Parse(reader["courseabsent"].ToString());
                            courseTask[len2] = int.Parse(reader["coursetask"].ToString());
                            courseMidTerm[len2] = int.Parse(reader["coursemidterm"].ToString());
                            courseFinalTerm[len2] = int.Parse(reader["coursefinalterm"].ToString());
                            courseScore[len2] = reader["coursescore"].ToString();

                            len2++;
                        }

                        reader.Close();

                    }


                    

                    

                    string[] studentName = new string[300];

                    for(int i = 0; i < len2; i++)
                    {
                        sql = String.Format("SELECT stdname FROM student WHERE stdnum = '{0}'", courseNum[i]);

                        command = new MySqlCommand(sql, mysql);

                        reader = command.ExecuteReader();

                        reader.Read();

                        studentName[i] = reader["stdname"].ToString();

                        reader.Close();

                    }
                    
                    mysql.Close();

                    double[] attend = new double[300];

                    for(int i = 0; i < len2; i++)
                    {
                        attend[i] = 0.0;

                        if (courseLate[i] > 3)
                        {
                            courseAbsent[i] += courseLate[i] / 3;
                        }

                        if (courseAbsent[i] != 0)
                        {
                            attend[i] = 100.0 - ((double)courseAbsent[i] / 16.0 * 100.0);
                        }
                        else
                        {
                            attend[i] = 100.0;
                        }
                    }



                    // 리스트뷰에 아이템 삽입
                    this.lvCourseStudent.Items.Clear();

                    for(int i = 0; i < len2; i++)
                    {
                        this.lvCourseStudent.Items.Add(new ListViewItem(new string[] { courseNum[i], studentName[i], attend[i] + "%" , Convert.ToString(courseTask[i]), Convert.ToString(courseMidTerm[i]),
                            Convert.ToString(courseFinalTerm[i]), courseScore[i] }));
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GradeViewDetail_Load(object sender, EventArgs e)
        {
            CourseStudent();
        }

        private void lvCourseStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                처음 실행시 정상적으로 this.txtSelectGrade.Text = this.lvGrade.SelectedItems[0].SubItems[1].Text; 이 출력되나
                두번째 선택 시 this.lvGrade.SelectedItems.Count의 값이 0이 됬다가 1이 되어
                    -> 선택이 해제 되었다가 다시 선택이 되어
                SelectedItems[0].SubItems[1]에서 오류가 발생하므로 아래의 조건문이 필요
             */
            if (this.lvCourseStudent.SelectedItems.Count == 0)
            { }
            else
            {
                this.txtSutdentNum.Text = this.lvCourseStudent.SelectedItems[0].SubItems[0].Text;
                this.txtStudentName.Text = this.lvCourseStudent.SelectedItems[0].SubItems[1].Text;
                this.txtTask.Text = this.lvCourseStudent.SelectedItems[0].SubItems[3].Text;
                this.txtMidTerm.Text = this.lvCourseStudent.SelectedItems[0].SubItems[4].Text;
                this.txtFinalTerm.Text = this.lvCourseStudent.SelectedItems[0].SubItems[5].Text;

                for(int i = 0; i < this.cbStudentScore.Items.Count; i++)
                {
                    if(this.cbStudentScore.Items[i].ToString() == this.lvCourseStudent.SelectedItems[0].SubItems[6].Text)
                    {
                        this.cbStudentScore.SelectedIndex = i;
                    }
                }


            }    
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string subjectCode = this.txtSubjectCode.Text;
            string studentNum = this.txtSutdentNum.Text;
            string task = this.txtTask.Text;
            string midTerm = this.txtMidTerm.Text;
            string finalTerm = this.txtFinalTerm.Text;
            string score = this.cbStudentScore.SelectedItem.ToString();

            try
            {
                string sql = "";


                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("UPDATE course SET coursetask = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", task, subjectCode, studentNum);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 1), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursemidterm = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", midTerm, subjectCode, studentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 2), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursefinalterm = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", finalTerm, subjectCode, studentNum);

                    command = new MySqlCommand(sql, mysql);

                    if (command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show(String.Format("데이터 처리에 오류가 발생했습니다 : {0}", 3), "알림");
                    }

                    sql = String.Format("UPDATE course SET coursescore = '{0}' WHERE coursecode = '{1}' AND coursenum = '{2}'", score, subjectCode, studentNum);

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

                CourseStudent();
            }


        }
    }
}
