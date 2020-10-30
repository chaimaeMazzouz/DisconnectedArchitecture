using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandingDataSet
{
    public partial class Form1 : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;
        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            // Addding Columns
            dc = new DataColumn("EmpID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("DepId", typeof(int));
            dt.Columns.Add(dc);
            // Adding Rows
            // Row 1
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "Mazzouz Chaimae";
            dr[2] = 10;
            dt.Rows.Add(dr);
            // Row 2
            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "Mazzouz Hamood";
            dr[2] = 16;
            dt.Rows.Add(dr);
            // Row 3
            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "Boutissante Issam";
            dr[2] = 12;
            dt.Rows.Add(dr);
            return dt;
        }
        DataTable GetDepartementTable()
        {
            dt = new DataTable("Departement");
            // Addding Columns
            dc = new DataColumn("DepId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };
            dc = new DataColumn("DepName", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("DepPlace", typeof(string));
            dt.Columns.Add(dc);
            // Adding Rows
            // Row 1
            dr = dt.NewRow();
            dr[0] = 10;
            dr[1] = "Adminustrater";
            dr[2] = "Left";
            dt.Rows.Add(dr);
            // Row 2
            dr = dt.NewRow();
            dr[0] = 16;
            dr[1] = "Game";
            dr[2] = "Centre";
            dt.Rows.Add(dr);
            // Row 3
            dr = dt.NewRow();
            dr[0] = 12;
            dr[1] = "Coding";
            dr[2] = "Left";
            dt.Rows.Add(dr);
            return dt;
        }
        DataSet GenerateDataSet()
        {
            DataTable emp = GetEmployeeTable();
            DataTable dep = GetDepartementTable();
           
            ds = new DataSet("MyDs");
            ds.Tables.Add(emp); // index = 0
            ds.Tables.Add(dep); // index = 1
            DataColumn col_pk = ds.Tables["Departement"].Columns["DepId"];
            DataColumn col_fk = ds.Tables["Employee"].Columns["DepId"];
            DataRelation Drel = new DataRelation("Emp_dep_rel", col_pk,col_fk);
            ds.Relations.Add(Drel);
            return ds;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet MyDs = GenerateDataSet();
            dataGridView1.DataSource = MyDs.Tables[0];
            dataGridView2.DataSource = MyDs.Tables[1];
        }
    }
}
