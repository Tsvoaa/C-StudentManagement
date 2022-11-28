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
    public partial class ErrorAdd : Form
    {
        DatabaseConnect db = new DatabaseConnect();

        string studentNum = "";

        public string TextStudentNum
        {
            set { this.studentNum = value; }
        }


        public ErrorAdd()
        {
            InitializeComponent();
        }

        private void AddErrorContent()
        {
            string errorContent = this.txtError.Text;

            try
            {
                string sql = "";

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("INSERT INTO error(errornum, errorcontent) values('{0}','{1}')", this.studentNum, errorContent);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    if(command.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("처리 중 오류가 발생했습니다.", "알림");
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 처리되었습니다.", "알림");
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddError_Click(object sender, EventArgs e)
        {
            AddErrorContent();
        }
    }
}
