using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Моя_группа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table1.Rows.Add(txtName.Text, txtFam.Text, txtOtch.Text, txtAdr.Text, txtNum.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            table1.Rows.RemoveAt(table1.SelectedCells[0].RowIndex);
        }
    }
}
