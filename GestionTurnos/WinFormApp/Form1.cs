using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formOut = new Form2();
            formOut.label5.Text = txtNombre.Text;
            formOut.label6.Text = txtApellido.Text;
            formOut.label7.Text=dtpNacimiento.Value.ToShortDateString();
            formOut.label8.Text = cmbxEspecialidad.SelectedItem.ToString();
            formOut.Show();
        }
    }
}
