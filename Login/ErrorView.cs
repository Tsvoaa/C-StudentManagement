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
    public partial class ErrorView : Form
    {
        DatabaseConnect db = new DatabaseConnect();

        public string TextStudentNum
        {
            set { this.txtStudentNum.Text = value; }
        }

        public string TextStudentName
        {
            set { this.txtStudentName.Text = value; }
        }

        public ErrorView()
        {
            InitializeComponent();
        }

        private void ErrorLoad()
        {
            string studentNum = this.txtStudentNum.Text;

            try
            {
                string sql = "";

                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    sql = String.Format("SELECT count(*) FROM error WHERE errornum = '{0}'", studentNum);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    int errorCount = int.Parse(reader["count(*)"].ToString());

                    reader.Close();


                    sql = String.Format("SELECT errorcontent FROM error WHERE errornum = '{0}'", studentNum);

                    command = new MySqlCommand(sql, mysql);
                    reader = command.ExecuteReader();

                    int len = 0;

                    string[] count = new string[errorCount];
                    string[] content = new string[errorCount];

                    while(reader.Read())
                    {
                        content[len] = reader["errorcontent"].ToString();

                        len++;
                    }

                    this.lvError.Items.Clear();

                    for(int i = 0; i < len; i++)
                    {
                        this.lvError.Items.Add(new ListViewItem(new String[] { Convert.ToString(i + 1), content[i] }));
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorView_Load(object sender, EventArgs e)
        {
            ErrorLoad();
        }

        private void btnAddError_Click(object sender, EventArgs e)
        {
            ErrorAdd errorAdd = new ErrorAdd();

            errorAdd.TextStudentNum = this.txtStudentNum.Text;

            errorAdd.ShowDialog();


        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            ErrorLoad();
        }
    }
}
