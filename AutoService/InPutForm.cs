using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class InPutForm : Form //форма для ввода данных
    {
        public string MechanicName { get; private set; }
        public int MechanicNumber { get; private set; }
        public InPutForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbNumber.Text, out int number) && !string.IsNullOrEmpty(tbName.Text))
            {
                MechanicNumber = number;
                MechanicName = tbName.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные данные. Номер должен быть числом, а имя не должно быть пустым.");
            }
        }
    }
}
