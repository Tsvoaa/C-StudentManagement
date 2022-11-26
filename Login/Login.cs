using System.Reflection;
using MySql.Data.MySqlClient;
using StudentManagement;


namespace Login
{
    public partial class LoginForm : Form
    {

        DatabaseConnect db = new DatabaseConnect();

        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = this.txtId.Text;
                string userPw = this.txtPw.Text;
                string memberId = "";
                string memberPw = "";


                using (MySqlConnection mysql = new MySqlConnection(db.connect()))
                {
                    mysql.Open();

                    string sql = String.Format("Select memberid, memberpw from member where memberid='{0}' and memberpw='{1}'", userId, userPw);

                    MySqlCommand command = new MySqlCommand(sql, mysql);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        memberId = reader["memberid"].ToString();
                        memberPw = reader["memberpw"].ToString();
                    }

                    if(userId == memberId && userPw == memberPw)
                    {
                        StudentForm stdForm = new StudentForm();
                        stdForm.Show();
                        this.Visible = false;

                        
                    }

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}