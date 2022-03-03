using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApplication
{
    public partial class ContactTypeForm : Form
    {
        public ContactTypeForm()
        {
            InitializeComponent();
        }

        private void ContactTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.ContactType". При необходимости она может быть перемещена или удалена.
            this.contactTypeTableAdapter.Fill(this.notebookDataSet.ContactType);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            contactTypeTableAdapter.Update(notebookDataSet.ContactType);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
