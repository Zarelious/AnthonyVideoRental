using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVideo.Forms
{
    public partial class AdminClientesFrm : Form
    {
        public AdminClientesFrm()
        {
            InitializeComponent();
        }

        public int vControl { get; set; }

        private void btnLista_Click(object sender, EventArgs e)
        {
            VideoCls.Class.ClientCls vCliente = new VideoCls.Class.ClientCls();
            GridClientes.DataSource = null;
            GridClientes.DataSource = vCliente.ListClient();
            GridClientes.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vControl = 1;
            labelNombre.Enabled = true;
            labelApellido.Enabled = true;
            labelEmail.Enabled = true;
            labelTelefono.Enabled = true;
            labelFN.Enabled = true;
            labelEstado.Enabled = true;
            labelDireccion.Enabled = true;
            labelComprobante.Enabled = true;
            labelSucursal.Enabled = true;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;
            btnLista.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            dtFechaNacimineto.Enabled = true;
            cbEstado.Enabled = true;
            txtDireccion.Enabled = true;
            txtComprobante.Enabled = true;
            cbSucursal.Enabled = true;
            btnAccion.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            VideoCls.Class.ClientCls vCliente = new VideoCls.Class.ClientCls();

            if (vControl == 1)
            {
                try
                {
                    vCliente.FirstName = txtNombre.Text.ToString();
                    vCliente.LastName = txtApellido.Text.ToString();
                    vCliente.email = txtEmail.Text.ToString();
                    vCliente.tele = txtTelefono.Text.ToString();
                    vCliente.DOB = Convert.ToDateTime(dtFechaNacimineto.Text.ToString());
                    vCliente.Status = cbEstado.Text.ToString();
                    vCliente.Address = txtDireccion.Text.ToString();
                    vCliente.ProofOfId = txtComprobante.Text.ToString();
                    vCliente.IdSucursal = Convert.ToInt32(cbSucursal.Text.ToString());

                    if (vCliente.InsertClient() == true)
                    {
                        labelNombre.Enabled = false;
                        labelApellido.Enabled = false;
                        labelEmail.Enabled = false;
                        labelTelefono.Enabled = false;
                        labelFN.Enabled = false;
                        labelEstado.Enabled = false;
                        labelDireccion.Enabled = false;
                        labelComprobante.Enabled = false;
                        labelSucursal.Enabled = false;
                        txtBuscar.Enabled = true;
                        btnBuscar.Enabled = true;

                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;
                        txtEmail.Enabled = false;
                        txtTelefono.Enabled = false;
                        dtFechaNacimineto.Enabled = false;
                        cbEstado.Enabled = false;
                        txtDireccion.Enabled = false;
                        txtComprobante.Enabled = false;
                        cbSucursal.Enabled = false;
                        btnAccion.Enabled = false;
                        btnCancelar.Enabled = false;

                        btnLista.Enabled = true;
                        btnEditar.Enabled = true;
                        btnEliminar.Enabled = true;

                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        dtFechaNacimineto.ResetText();
                        cbEstado.ResetText();
                        txtDireccion.Clear();
                        txtComprobante.Clear();
                        cbSucursal.ResetText();
                        GridClientes.DataSource = null;
                        GridClientes.DataSource = vCliente.ListClient();
                        GridClientes.Refresh();
                        MessageBox.Show("Se ha registrado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la operacion");
                    }
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error al insertar nuevo usuario, verifique los datos e intente de nuevo");

                }
            }
            else if (vControl == 2)
            {
                DialogResult vrespuesta = MessageBox.Show("Se editara la informacion del cliente, desea continuar?", "", MessageBoxButtons.YesNo);
                if (vrespuesta == DialogResult.Yes)
                {
                    try
                    {
                        vCliente.FirstName = txtNombre.Text.ToString();
                        vCliente.LastName = txtApellido.Text.ToString();
                        vCliente.email = txtEmail.Text.ToString();
                        vCliente.tele = txtTelefono.Text.ToString();
                        vCliente.DOB = Convert.ToDateTime(dtFechaNacimineto.Text.ToString());
                        vCliente.Status = cbEstado.Text.ToString();
                        vCliente.Address = txtDireccion.Text.ToString();
                        vCliente.ProofOfId = txtComprobante.Text.ToString();
                        vCliente.IdSucursal = Convert.ToInt32(cbSucursal.Text.ToString());
                        vCliente.IdClient = Convert.ToInt32(txtID.Text.ToString());


                        if (vCliente.UpdateClient() == true)
                        {
                            labelID.Visible = false;
                            txtID.Visible = false;
                            labelNombre.Enabled = false;
                            labelApellido.Enabled = false;
                            labelEmail.Enabled = false;
                            labelTelefono.Enabled = false;
                            labelFN.Enabled = false;
                            labelEstado.Enabled = false;
                            labelDireccion.Enabled = false;
                            labelComprobante.Enabled = false;
                            labelSucursal.Enabled = false;
                            txtBuscar.Enabled = true;
                            btnBuscar.Enabled = true;

                            txtNombre.Enabled = false;
                            txtApellido.Enabled = false;
                            txtEmail.Enabled = false;
                            txtTelefono.Enabled = false;
                            dtFechaNacimineto.Enabled = false;
                            cbEstado.Enabled = false;
                            txtDireccion.Enabled = false;
                            txtComprobante.Enabled = false;
                            cbSucursal.Enabled = false;
                            btnAccion.Enabled = false;
                            btnCancelar.Enabled = false;

                            btnLista.Enabled = true;
                            btnAgregar.Enabled = true;
                            btnEliminar.Enabled = true;

                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            dtFechaNacimineto.ResetText();
                            cbEstado.ResetText();
                            txtDireccion.Clear();
                            txtComprobante.Clear();
                            cbSucursal.ResetText();
                            GridClientes.DataSource = null;
                            GridClientes.DataSource = vCliente.ListClient();
                            GridClientes.Refresh();
                            MessageBox.Show("Se ha guardado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Fallo en la operacion");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Se ha producido un error al editar usuario, verifique los datos e intente de nuevo");

                    }
                }
            }
            else if (vControl == 3)
            {
                DialogResult vrespuesta = MessageBox.Show("Se eliminara la informacion del cliente, desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (vrespuesta == DialogResult.Yes)
                {
                    try
                    {
                        vCliente.IdClient = Convert.ToInt32(txtID.Text.ToString());

                        if (vCliente.DeleteClient() == true)
                        {
                            labelID.Visible = false;
                            txtID.Visible = false;
                            labelNombre.Enabled = false;
                            labelApellido.Enabled = false;
                            labelEmail.Enabled = false;
                            labelTelefono.Enabled = false;
                            labelFN.Enabled = false;
                            labelEstado.Enabled = false;
                            labelDireccion.Enabled = false;
                            labelComprobante.Enabled = false;
                            labelSucursal.Enabled = false;
                            txtBuscar.Enabled = true;
                            btnBuscar.Enabled = true;

                            txtNombre.Enabled = false;
                            txtApellido.Enabled = false;
                            txtEmail.Enabled = false;
                            txtTelefono.Enabled = false;
                            dtFechaNacimineto.Enabled = false;
                            cbEstado.Enabled = false;
                            txtDireccion.Enabled = false;
                            txtComprobante.Enabled = false;
                            cbSucursal.Enabled = false;
                            btnAccion.Enabled = false;
                            btnCancelar.Enabled = false;

                            btnLista.Enabled = true;
                            btnAgregar.Enabled = true;
                            btnEditar.Enabled = true;

                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            dtFechaNacimineto.ResetText();
                            cbEstado.ResetText();
                            txtDireccion.Clear();
                            txtComprobante.Clear();
                            cbSucursal.ResetText();
                            GridClientes.DataSource = null;
                            GridClientes.DataSource = vCliente.ListClient();
                            GridClientes.Refresh();
                            MessageBox.Show("Se ha eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido un error al completar la operacion");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Se ha producido un error, verifique el ID");
                    }

                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            labelID.Visible = true;
            txtID.Visible = true;
            labelNombre.Enabled = true;
            labelApellido.Enabled = true;
            labelEmail.Enabled = true;
            labelTelefono.Enabled = true;
            labelFN.Enabled = true;
            labelEstado.Enabled = true;
            labelDireccion.Enabled = true;
            labelComprobante.Enabled = true;
            labelSucursal.Enabled = true;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;

            btnLista.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            dtFechaNacimineto.Enabled = true;
            cbEstado.Enabled = true;
            txtDireccion.Enabled = true;
            txtComprobante.Enabled = true;
            cbSucursal.Enabled = true;
            btnAccion.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VideoCls.Class.ClientCls vCliente = new VideoCls.Class.ClientCls();
            try
            {
                vCliente.IdClient = Convert.ToInt32(txtBuscar.Text.ToString());

                GridClientes.DataSource = null;
                GridClientes.DataSource = vCliente.SearchClient();
                GridClientes.Refresh();
            }
            catch
            {
                MessageBox.Show("El ID no existe");
            }
        }

        private void AdminClientesFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            labelID.Visible = false;
            txtID.Visible = false;
            labelNombre.Enabled = false;
            labelApellido.Enabled = false;
            labelEmail.Enabled = false;
            labelTelefono.Enabled = false;
            labelFN.Enabled = false;
            labelEstado.Enabled = false;
            labelDireccion.Enabled = false;
            labelComprobante.Enabled = false;
            labelSucursal.Enabled = false;
            btnBuscar.Enabled = true;
            txtBuscar.Enabled = true;

            btnLista.Enabled = true;
            btnEditar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            dtFechaNacimineto.Enabled = false;
            cbEstado.Enabled = false;
            txtDireccion.Enabled = false;
            txtComprobante.Enabled = false;
            cbSucursal.Enabled = false;
            btnAccion.Enabled = false;
            btnCancelar.Enabled = false;

            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dtFechaNacimineto.ResetText();
            cbEstado.ResetText();
            txtDireccion.Clear();
            txtComprobante.Clear();
            cbSucursal.ResetText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vControl = 3;
            labelID.Visible = true;
            txtID.Visible = true;
            labelNombre.Enabled = false;
            labelApellido.Enabled = false;
            labelEmail.Enabled = false;
            labelTelefono.Enabled = false;
            labelFN.Enabled = false;
            labelEstado.Enabled = false;
            labelDireccion.Enabled = false;
            labelComprobante.Enabled = false;
            labelSucursal.Enabled = false;
            btnBuscar.Enabled = false;
            txtBuscar.Enabled = false;

            btnLista.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = false;


            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            dtFechaNacimineto.Enabled = false;
            cbEstado.Enabled = false;
            txtDireccion.Enabled = false;
            txtComprobante.Enabled = false;
            cbSucursal.Enabled = false;
            btnAccion.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
