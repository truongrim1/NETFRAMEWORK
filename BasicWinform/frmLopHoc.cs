using BasicWinform.Entities;
using BasicWinForm.Entities;
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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
            cmbKhoa.DataSource = Faculty.GetList();
            cmbKhoa.DisplayMember = "Name";
            cmbKhoa.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmbKhoa.SelectedIndex;
            var item = cmbKhoa.SelectedItem as Faculty;//unbox
            var lsPerson =Person.GetList(item.Id);
            personBindingSource.DataSource = lsPerson;
            griddssv.DataSource = personBindingSource;
        }
    }
}
