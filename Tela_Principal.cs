using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_LG
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }



        private void pictureCarro_Click(object sender, EventArgs e)
        {
            FormCarro formCarro = new FormCarro();
            formCarro.Show();
        }

        private void pictureColaborador_Click(object sender, EventArgs e)
        {
            FormColaborador formColaborador = new FormColaborador();
            formColaborador.Show();
        }
    }
}
