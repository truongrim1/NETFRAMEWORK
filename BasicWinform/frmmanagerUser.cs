using BasicWinform.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class frmmanagerUser : Form
    {
        public frmmanagerUser()
        {
            InitializeComponent();
            var ls = Person.GetList();
            personBindingSource.DataSource = ls;
            gridSinhVien.DataSource = ls;
        }

        private void frmmanagerUser_Load(object sender, EventArgs e)
        {

        }
    }
}
