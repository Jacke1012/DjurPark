using DjurPark.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser;

namespace DjurPark
{
    public partial class SizeChanging : Form
    {
        Djur animal;
        public SizeChanging(Djur animal)
        {
            this.animal = animal;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            double weight, length, height;
            AnimalSize temp = null;
            if (TryParse.Double(tbxWeight, out weight)&& TryParse.Double(tbxLength, out length) && TryParse.Double(tbxHeight, out height))
            {
                temp = new AnimalSize((float)weight, (float)length, (float)height);
            }
            animal.size = temp;
            Close();
        }
    }
}
