using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace inforNV
{
    public partial class Form1 : Form
    {
        SqlConnection con1; //doi tuong thuc hien ket noi database
        //SqlCommand cmd;//doi tuong thuc hien cau truy van
        SqlDataAdapter dap1;//doi tuong gan ket DataSource voi DataSet
        DataSet ds;//doi tuong chua du lieu o local
        DataTable dat;
        string connect = @"Data Source=(localdb)\ProjectsV13; Initial Catalog=QLNHAHANG";
        string query;
        public Form1()
        {
            InitializeComponent();
        }

    }
}
