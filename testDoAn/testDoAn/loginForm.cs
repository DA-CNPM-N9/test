using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inforNV;
namespace testDoAn
{
    
    public partial class loginForm : Form
    {
        SqlConnection con; //doi tuong thuc hien ket noi database
        //SqlCommand cmd;//doi tuong thuc hien cau truy van
        SqlDataAdapter dap;//doi tuong gan ket DataSource voi DataSet
        DataSet ds;//doi tuong chua du lieu o local
        DataTable dat;
        string connect = @"Data Source=(localdb)\ProjectsV13; Initial Catalog=QLNHAHANG";
        string query;
        public loginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click (Object sender, EventArgs e)
        {
            if (isValid())
            {
                con = new SqlConnection(connect);
                {
                    query = "SELECT * FROM NHANVIEN WHERE MaNV = '" + txtUser.Text.Trim() + "' AND MatKhau = '" + txtPass.Text.Trim() + "'";
                    dap = new SqlDataAdapter(query, con);
                    dat = new DataTable();
                    dap.Fill(dat);
                    if (dat.Rows.Count == 1)
                    {
                        MessageBox.Show("Welcome " + txtUser.Text);
                        goiFormInfor();
                    }
                    else MessageBox.Show("Your user is not valid");
                }
            }
            else MessageBox.Show("Your user no valid!");
        }
        private void btnExit_Click (Object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool isValid()
        {
            if (txtUser.Text == string.Empty)
            {
                MessageBox.Show("Enter your user!");
                return false;
            }
            if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Enter your pass!");
                return false;
            }
            return true;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPass.Focus();
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin.Focus();
        }
        private void goiFormInfor ()
        {
            inforNV.Form1 formNV = new Form1();
            this.Hide();
            formNV.ShowDialog();
            this.Show();
        }
    }
}
