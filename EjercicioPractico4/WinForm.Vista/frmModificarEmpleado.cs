using LabTP4.Logic;
using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Vista
{
    public partial class frmModificarEmpleado : Form
    {

        public frmModificarEmpleado()
        {
            InitializeComponent();

        }

        private void frmModificarEmpleado_Load(object sender, EventArgs e)
        {           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            EmployeeLogic el = new EmployeeLogic();

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
                //employee.Photo = pbFoto.Image(); solucionar errores de foto
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

                el.Update(employee);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
