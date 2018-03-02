using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazDoctores
{
    public partial class Form1 : Form
    {
        private int total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'doctoresDataSet.doctor' Puede moverla o quitarla según sea necesario.
            this.doctorTableAdapter.Fill(this.doctoresDataSet.doctor);
            this.total = doctorBindingSource.Count;
            this.set_current_text();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.change_to_first();
        }

        private void change_to_first()
        {
            doctorBindingSource.Position = 0;
            this.set_current_text();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.change_to_last();
        }

        private void change_to_last()
        {
            doctorBindingSource.Position = this.total - 1;
            this.set_current_text();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.previous();
        }

        private void previous()
        {
            doctorBindingSource.Position -= 1;
            this.set_current_text();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.next();
        }

        private void next()
        {
            doctorBindingSource.Position += 1;
            this.set_current_text();
        }

        private void set_current_text()
        {
            int current = doctorBindingSource.Position + 1;
            textBox2.Text = current.ToString() + " / " + this.total.ToString();
        }

        private void get_value()
        {
            DoctoresDataSet.doctorRow[] doctors = doctoresDataSet.doctor.ToArray();
            textBox2.Text = doctors[0].TURNO;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.get_value();
        }
    }
}
