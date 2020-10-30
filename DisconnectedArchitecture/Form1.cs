using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArchitecture
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;

        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            // Addding Columns
            dc = new DataColumn("EmpID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("EmpEmail", typeof(string));
            dt.Columns.Add(dc);
            // Adding Rows
            // Row 1
            dr = dt.NewRow();
            dr[0] = 12;
            dr[1] = "Mazzouz Chaimae";
            dr[2] = "mazzouz.chaimae.dev@gmail.com";
            dt.Rows.Add(dr);
            // Row 2
            dr = dt.NewRow();
            dr[0] = 16;
            dr[1] = "Mazzouz Hamood";
            dr[2] = "mazzouz.hamood.dev@gmail.com";
            dt.Rows.Add(dr);
            // Row 3
            dr = dt.NewRow();
            dr[0] = 11;
            dr[1] = "Boutissante Issam";
            dr[2] = "boutissante.issam.dev@gmail.com";
            dt.Rows.Add(dr);
            return dt;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable EmployeeTable = GetEmployeeTable();
            dataGridView1.DataSource = EmployeeTable;
        }
    }
}
