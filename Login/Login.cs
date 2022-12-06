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

            string userId = this.txtId.Text;
            string userPw = this.txtPw.Text;
            string memberId = "";
            string memberPw = "";

            string query = String.Format("SELECT memberid, memberpw FROM member WHERE memberid = '{0}' AND memberpw = '{1}'", userId, userPw);

            string[,] result = db.SqlSelect(query, 2);

            memberId = result[0,0];
            memberPw = result[0,1];

            if (userId == memberId && userPw == memberPw)
            {
                StudentForm stdForm = new StudentForm();

                stdForm.ShowDialog();

                this.Close();
            }
            
        }
    }
}