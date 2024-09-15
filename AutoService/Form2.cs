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
    public partial class Form2 : Form
    {
        public delegate void MechanicUpdatedEventHandler(object sender, EventArgs e);
        public event MechanicUpdatedEventHandler MechanicUpdated;


        private string _originalMechanicName;
        public Form2(string mechanicName)
        {
            InitializeComponent();
            _originalMechanicName = mechanicName;
            tbNameMechanic.Text = mechanicName;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string mechanicName = tbNameMechanic.Text;
            //Подтверждение удаления
           var result = MessageBox.Show(
           $"Вы уверены, что хотите удалить механика с именем '{mechanicName}'?",
           "Подтверждение удаления",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
       );
            if (result == DialogResult.Yes) 
            { 
                DBWork.DeleteMechanic(mechanicName);
                MechanicUpdated?.Invoke(this, EventArgs.Empty); // Уведомление о том, что механик был удален
                this.Close();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newMechanicName = tbNameMechanic.Text.Trim();
            var result = MessageBox.Show(
                $"Вы уверены, что хотите изменить имя механика с '{_originalMechanicName}' на '{newMechanicName}'?",
                "Подтверждение изменений",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question


            );

            if (result == DialogResult.Yes)
            {


                // Обновление имени механика
                DBWork.UpdateMechanicName(_originalMechanicName, newMechanicName);
                MessageBox.Show("Имя механика изменено успешно.");
                MechanicUpdated?.Invoke(this, EventArgs.Empty); // Уведомление о том, что имя механика было изменено
                this.Close(); // Закрыть форму после изменения
            }   
                
        }
    }
}
