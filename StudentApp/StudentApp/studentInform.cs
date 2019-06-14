using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class studentInform : Form
    {
        private DataTable stdobjTable;
        private Entity.Student stdobj = new Entity.Student();
        public studentInform()
        {
            InitializeComponent();
        }

        private void studentInform_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            stdobjTable = new DataTable();
            stdobjTable.Columns.Add("Name");
            stdobjTable.Columns.Add("ID");
            stdobjTable.Columns.Add("Level");
            stdobjTable.Columns.Add("Term");

            stdobj.Name = NameInput.Text.ToString();
            stdobj.ID = ID.Text.ToString();
            stdobj.Level = Level.Text.ToString();
            stdobj.Term = Term.Text.ToString();
            
            stdobjTable.Rows.Add(stdobj.Name, stdobj.ID, stdobj.Level, stdobj.Term);
            studentinfoview.DataSource = stdobjTable;
            
            NameInput.Clear();
            ID.Clear();
            Level.Clear();
            Term.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
