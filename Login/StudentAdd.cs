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
    public partial class StudentAdd : Form
    {

        DatabaseConnect db = new DatabaseConnect();

        public StudentAdd()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtName.Text != "")
            {
                if(this.txtNumber.Text != "")
                {
                    if(this.cbGrade.SelectedItem != null)
                    {
                        if(this.cbClasses.SelectedItem != null)
                        {
                            if (this.cbGender.SelectedItem != null)
                            {
                                if (this.cbArmy.SelectedItem != null)
                                {
                                    if (this.cbGender.SelectedIndex.ToString() == "여성" && this.cbArmy.SelectedIndex.ToString() != "해당없음")
                                    {
                                        MessageBox.Show("여자는 군필을 해당없음으로 설정해주세요!", "알림");


                                    }
                                    else
                                    {
                                        if(this.cbSemester.SelectedItem != null)
                                        {
                                            string name = this.txtName.Text;
                                            string number = this.txtNumber.Text;
                                            string grade = this.cbGrade.SelectedItem.ToString();
                                            string gender = this.cbGender.SelectedItem.ToString();
                                            string army = this.cbArmy.SelectedItem.ToString();
                                            string classes = this.cbClasses.SelectedItem.ToString();
                                            string semester = this.cbSemester.SelectedItem.ToString();

                                            if (army == "군필")
                                            {
                                                army = "T";
                                            }
                                            else if (army == "미필")
                                            {
                                                army = "F";
                                            }
                                            else if (army == "해당없음")
                                            {
                                                army = "N";
                                            }

                                            try
                                            {

                                                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                                                {
                                                    mysql.Open();


                                                    string sql = "";

                                                    sql = String.Format("insert into student values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", number, name, grade, classes, semester, gender, army, 0, 0);


                                                    MySqlCommand command = new MySqlCommand(sql, mysql);

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
                                        else
                                        {
                                            MessageBox.Show("학기를 선택해주세요!", "알림");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("군필 여부를 선택해주세요!", "알림");
                                }
                            }
                            else
                            {
                                MessageBox.Show("성별을 선택해주세요!", "알림");
                            }
                        }
                        else
                        {
                            MessageBox.Show("반을 선택해주세요!", "알림");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("학년을 선택해주세요!", "알림");
                    }
                }
                else
                {
                    MessageBox.Show("학번을 입력해주세요!", "알림");
                }
            }
            else
            {
                MessageBox.Show("이름을 입력해주세요!", "알림");
            }
            
        }

        private void lblClasses_Click(object sender, EventArgs e)
        {

        }
    }
}
