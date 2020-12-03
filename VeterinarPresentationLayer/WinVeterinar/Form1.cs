using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetBussinessLayer;
using VetDataAccessLayer.Models;

namespace WinVeterinar
{
    public partial class FormVeterinar : Form
    {
        private  VeterinarBussiness veterinarBussiness;
        public FormVeterinar()
        {
            this.veterinarBussiness = new VeterinarBussiness();
            InitializeComponent();
        }

        private void FormVeterinar_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            //listBoxIspis.Items.Clear();
            this.veterinarBussiness = new VeterinarBussiness();

            List<Veterinar> veterinars = this.veterinarBussiness.GetallVeterinars();

            foreach (Veterinar v in veterinars)
            {
                listBoxIspis.Items.Add(v.Id + "." + v.FullName + "," + v.Specialy + "," + v.Years + " ");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Veterinar v = new Veterinar();
            v.FullName = textBoxIme.Text;
            v.Specialy = textBoxSpecijalnost.Text;
            v.Years = Convert.ToInt32(textBoxGod.Text);

            bool result = this.veterinarBussiness.InsertVeterinar(v);

            if (result)
            {
                FillList();
                MessageBox.Show("Uspesan unos!");
                textBoxIme.Text = " ";
                textBoxSpecijalnost.Text = " ";
                textBoxGod.Text = " ";
            }
            else
            {
                MessageBox.Show("Neuspesan unos!");
            }
        }
    }
    }

