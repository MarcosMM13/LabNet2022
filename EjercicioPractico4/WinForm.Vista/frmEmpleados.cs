using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTP4.Entities;
using LabTP4.Logic;

namespace WinForm.Vista
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EmployeeLogic el = new EmployeeLogic();
            Employee employee = new Employee();
            string imagen = openFileDialog1.FileName;
            pbFoto.Image = Image.FromFile(imagen);

            try
            {
                employee.LastName = txtApellido.Text;
                employee.FirstName = txtNombre.Text;
                employee.Title = txtNombre.Text;
                employee.TitleOfCourtesy = txtNombre.Text;
                employee.BirthDate = dtpNacimiento.Value;
                employee.HireDate = dtpContratacion.Value;
                employee.Address = txtDomicilio.Text;
                employee.City = txtCiudad.Text;
                employee.Country = txtPais.Text;
                employee.HomePhone = txtTelefono.Text;
                employee.Extension = txtExtencion.Text;
                employee.PostalCode = txtCodigoPostal.Text;
              
                employee.Region = txtRegion.Text;
                employee.ReportsTo = int.Parse(txtReporte.Text);
                employee.Notes = txtNotas.Text;
                employee.PhotoPath = txtRutaFoto.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
               
            }


            try
            {
                el.Add(employee);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmployeeLogic el = new EmployeeLogic();
            int? id = int.Parse(dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells[0].Value.ToString()); ;
            //el.GetId(id);

            if (id != null)
            {
                frmModificarEmpleado frmModificar = new frmModificarEmpleado();
                frmModificar.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            EmployeeLogic el = new EmployeeLogic();

            try
            {
                var empleados = el.GetAll();

                dgvEmpleado.DataSource = null;
                dgvEmpleado.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"el error es /n{ex.Message}");
            }
        }

        private void AgregarFoto()
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                   pbFoto.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"El archivo seleccionado no es un tipo de imagen válido - {ex.Message}");
            }
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            AgregarFoto();
        }
        //private int? GetId()
        //{
        //    try
        //    {
        //  return int.Parse(dgvEmpleado.Rows[dgvEmpleado.CurrentRow.Index].Cells[0].Value.ToString());
        //                    }
        //    catch 
        //    {
        //        return null;               
        //    }
        //}
    }
}
