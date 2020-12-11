using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DjurPark.Classes;

namespace DjurPark
{
    public partial class Form1 : Form
    {
        public static DateTime currentDate;
        public Form1()
        {
            InitializeComponent();
        }
        object[] animalsTypes = new object[] { new Tiger("",DateTime.Now) };
        List<Djur> allAnimals = new List<Djur>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var animalType in animalsTypes)
            {
                cmbDjur.Items.Add(animalType.GetType().Name);
            }
        }

        private void NewAnimal_Click(object sender, EventArgs e)
        {
            if (cmbDjur.SelectedIndex!=-1 && tbxName.Text !="" && cmbGender.SelectedIndex != -1)
            {
                Djur temp = (Djur)Activator.CreateInstance(animalsTypes[cmbDjur.SelectedIndex].GetType(), new object[] { tbxName.Text, datePicker.Value });
                temp.gender = (Gender)cmbGender.SelectedIndex;
                allAnimals.Add(temp);
                RefrehsLbx();
            }
        }
        void RefrehsLbx()
        {
            lbxAllAnimals.Items.Clear();
            lbxAllAnimals.Items.AddRange(allAnimals.ToArray());
        }
        private void lbxAllAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxItemView.Text = ((Djur)lbxAllAnimals.SelectedItem).PrintInfo();
        }

        private void lbxAllAnimals_DoubleClick(object sender, EventArgs e)
        {
            if (lbxAllAnimals.SelectedIndex != -1)
            {
                SizeChanging sizeChanging = new SizeChanging(allAnimals[lbxAllAnimals.SelectedIndex]);
                sizeChanging.ShowDialog();
                int tempSelectedIndex = lbxAllAnimals.SelectedIndex;
                RefrehsLbx();
                lbxAllAnimals.SelectedIndex = tempSelectedIndex;
                tbxItemView.Text = ((Djur)lbxAllAnimals.SelectedItem).PrintInfo();
            }
        }
    }
}
