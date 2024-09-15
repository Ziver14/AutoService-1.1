using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!FSWork.IsFileExist("AutoService.db")) MakeStore();
            FillMechanicsNames();
        }
        private void MakeStore()
        {
            if (DBWork.MakeDB())
            {
                MessageBox.Show($"База данных существует");
            } ;
        }
        private void FillMechanicsNames()
        {
            cmbMechanic.Items.Clear();
            foreach (string name in DBWork.GetMechanics())
            {
                cmbMechanic.Items.Add(name);
            }
        }

		private void picBoxAvatar_Click(object sender, EventArgs e)
		{
            if (cmbMechanic.SelectedItem != null)
            {
                byte[] _image = FSWork.GetImage();
                string _name = cmbMechanic.SelectedItem.ToString();
                DBWork.AddAvatar(_name, _image);
            }
		}
        private void SetImage2PictureBox()
        {
			string _name = cmbMechanic.SelectedItem.ToString();
			MemoryStream ms = DBWork.GetAvatar(_name);
            if (ms != null)
            {
                picBoxAvatar.Image =
                Image.FromStream(DBWork.GetAvatar(_name));
            }
            else 
            {
                picBoxAvatar.BackColor = Color.Black;
                picBoxAvatar.Image = null;
            } 
                

            
        }

		private void cmbMechanic_SelectedValueChanged(object sender, EventArgs e)
		{
            SetImage2PictureBox();
		}

        private void btnEdit_Click(object sender, EventArgs e) 
        {
            //Проверка на то что механик выбран
            if (cmbMechanic.SelectedItem != null)
            {
                string selectMechanic = cmbMechanic.SelectedItem.ToString();
                Form2 form2 = new Form2(selectMechanic); //при вызове второй формы сразу получаем значение в ComboBox и передаем его во вторую форму
                form2.MechanicUpdated += Form2_MechanicUpdated; // Подписка на событие обновления
                form2.Show();
            }
            else { MessageBox.Show("Выберите механика"); }
               
        }

        private void Form2_MechanicUpdated(object sender, EventArgs e)
        {
            string selectedMechanic = cmbMechanic.SelectedItem?.ToString(); // Запомнить текущий выбранный механик
            FillMechanicsNames(); // Обновление списка механиков после изменений
            if (selectedMechanic != null && cmbMechanic.Items.Contains(selectedMechanic))
            {
                cmbMechanic.SelectedItem = selectedMechanic; // Установить ранее выбранный элемент
                SetImage2PictureBox(); // Обновление изображения в PictureBox
            }
        }


    }
}
