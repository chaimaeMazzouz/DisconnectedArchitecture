using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace SerializingDataSet
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void XML_btn_Click(object sender, EventArgs e)
        {
            DataTable emp = GetEmployeeTable();
            emp.WriteXml(@"C:\Users\MZ\Desktop\Desktop-Client-Serveur\ADO-Code-Practice\data.xml");
        }

        private void JSON_btn_Click(object sender, EventArgs e)
        {
            DataTable emp = GetEmployeeTable();
            string json = JsonConvert.SerializeObject(emp);
            StreamWriter writer = File.CreateText(@"C:\Users\MZ\Desktop\Desktop-Client-Serveur\ADO-Code-Practice\data.json");
            writer.WriteLine(json);
            writer.Close();
        }
    }
}
