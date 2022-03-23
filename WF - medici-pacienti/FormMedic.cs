using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___medici_pacienti
{
    public partial class FormMedic : Form
    {
        public Medic mFormMedic;
        public FormMedic(Medic m)
        {
            InitializeComponent();
            mFormMedic = m;

            button1.Text = "Adauga";
            if (m != null)
            {
                button1.Text = "Editeaza";
                textBoxNume.Text = m.NumePrenume;
                textBoxCNP.Text = m.Cnp;
                dateTimePickerDataNasterii.Value = m.DataNasterii;
                comboBoxAn.Text = m.AnAbsolvire.ToString();
                comboBoxSpecializare.Text = m.Specializare;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mFormMedic is null) mFormMedic = new Medic();
            mFormMedic.NumePrenume = textBoxNume.Text;
            mFormMedic.DataNasterii = dateTimePickerDataNasterii.Value;
            mFormMedic.Cnp = textBoxCNP.Text;
            mFormMedic.AnAbsolvire = Convert.ToInt32(comboBoxAn.Text);
            mFormMedic.Specializare = comboBoxSpecializare.Text;
        }
    }
}
