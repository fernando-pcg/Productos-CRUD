using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_Logica;

namespace Producto_Presentacion
{
    public partial class Form1 : Form
    {
        Productos p = new Productos();
        private int m = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Existencia = int.Parse(txtExistencia.Text);
                p.Marca = txtMarca.Text;
                p.Categoria = txtCategoria.Text;
                p.Estado = cbbEstado.SelectedIndex;
                p.FechaCreacion = dtpC.Value.Date.ToShortDateString();
                p.FechaVencimiento = dtpV.Value.Date.ToShortDateString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            int n = dataGridView1.Rows.Add();
            try
            {
                dataGridView1.Rows[n].Cells[0].Value = p.Nombre;
                dataGridView1.Rows[n].Cells[2].Value = p.Descripcion;
                dataGridView1.Rows[n].Cells[1].Value = p.Existencia;
                dataGridView1.Rows[n].Cells[5].Value = p.Marca;
                dataGridView1.Rows[n].Cells[7].Value = p.Categoria;
                switch (p.Estado)
                {
                    case 0:
                        dataGridView1.Rows[n].Cells[2].Value = "Activo";
                        break;
                    case 1:
                        dataGridView1.Rows[n].Cells[2].Value = "Inactivo";
                        break;
                }
                dataGridView1.Rows[n].Cells[4].Value = p.FechaCreacion;
                dataGridView1.Rows[n].Cells[3].Value = p.FechaVencimiento;

                p.Nombre = "";
                p.Descripcion = "";
                p.Existencia = 0;
                p.Marca = "";
                p.Categoria = "";
                p.Estado = 3;
                p.FechaCreacion = "";
                p.FechaVencimiento = "";
                lblInformacion.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (m != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(m);
                    lblInformacion.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay elementos para eliminar");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int m = e.RowIndex;

            if (m != -1)
            {

                lblInformacion.Text = (string)dataGridView1.Rows[m].Cells[0].Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m != -1)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(m);
                    lblInformacion.Text = "";
                    try
                    {
                        p.Nombre = txtNombre.Text;
                        p.Descripcion = txtDescripcion.Text;
                        p.Existencia = int.Parse(txtExistencia.Text);
                        p.Marca = txtMarca.Text;
                        p.Categoria = txtCategoria.Text;
                        p.Estado = cbbEstado.SelectedIndex;
                        p.FechaCreacion = dtpC.Value.Date.ToShortDateString();
                        p.FechaVencimiento = dtpV.Value.Date.ToShortDateString();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    int n = dataGridView1.Rows.Add();
                    try
                    {
                        dataGridView1.Rows[n].Cells[0].Value = p.Nombre;
                        dataGridView1.Rows[n].Cells[2].Value = p.Descripcion;
                        dataGridView1.Rows[n].Cells[1].Value = p.Existencia;
                        dataGridView1.Rows[n].Cells[5].Value = p.Marca;
                        dataGridView1.Rows[n].Cells[7].Value = p.Categoria;
                        switch (p.Estado)
                        {
                            case 0:
                                dataGridView1.Rows[n].Cells[2].Value = "Activo";
                                break;
                            case 1:
                                dataGridView1.Rows[n].Cells[2].Value = "Inactivo";
                                break;
                        }
                        dataGridView1.Rows[n].Cells[4].Value = p.FechaCreacion;
                        dataGridView1.Rows[n].Cells[3].Value = p.FechaVencimiento;

                        p.Nombre = "";
                        p.Descripcion = "";
                        p.Existencia = 0;
                        p.Marca = "";
                        p.Categoria = "";
                        p.Estado = 3;
                        p.FechaCreacion = "";
                        p.FechaVencimiento = "";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay elementos para actualizar");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInformacion.Text = "";
        }
    }
}
