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
    public partial class FormProgramare : Form
    {
        Medic mFormProgramare;
        Pacient pFormProgramare;
        public DateTime dataOraProgramare;
        public FormProgramare(Medic m, Pacient p)
        {
            InitializeComponent();
            mFormProgramare = m;
            pFormProgramare = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
