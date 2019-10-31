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
    public partial class RentasFrm : Form
    {
        public RentasFrm()
        {
            InitializeComponent();
        }

        private void VentasRentFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataVidDataSet2.Rental' Puede moverla o quitarla según sea necesario.
            //this.rentalTableAdapter.Fill(this.dataVidDataSet2.Rental);
            // TODO: esta línea de código carga datos en la tabla 'dataVidDataSet1.Client' Puede moverla o quitarla según sea necesario.
            //this.clientTableAdapter.Fill(this.dataVidDataSet1.Client);
            // TODO: esta línea de código carga datos en la tabla 'dataVidDataSet.Movie' Puede moverla o quitarla según sea necesario.
            //this.movieTableAdapter.Fill(this.dataVidDataSet.Movie);
            loadCombo();
        }

        private void loadCombo()
        {
            
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            cbIdPelicula.DisplayMember = "Name";
            cbIdPelicula.ValueMember = "IdMovie";
            cbIdPelicula.DataSource = mMovie.ListMovies();

            VideoCls.Class.ClientCls clientCls = new VideoCls.Class.ClientCls();
            cbIdCliente.DisplayMember = "FirstName";
            cbIdCliente.ValueMember = "IdClient";
            cbIdCliente.DataSource = clientCls.ListClient();

            VideoCls.Class.SucursalCls mSucursal = new VideoCls.Class.SucursalCls();
            cbIdSucursal.DisplayMember = "Name";
            cbIdSucursal.ValueMember = "IdSucursal";
            cbIdSucursal.DataSource = mSucursal.ListSucursal();


        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            VideoCls.Class.RentalCls mRental = new VideoCls.Class.RentalCls();
            GridRentas.DataSource = null;
            GridRentas.DataSource = mRental.ListRent();
            GridRentas.Refresh();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnLista.Enabled = false;
            cbBuscar.Enabled = false;
            btnBuscar.Enabled = false;
            cbIdCliente.Enabled = true;
            cbIdPelicula.Enabled = true;
            cbIdSucursal.Enabled = true;
            dtFecha.Enabled = true;
            btnOK.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            VideoCls.Class.RentalCls mRental = new VideoCls.Class.RentalCls();
            VideoCls.DAL.AdminDataTableAdapters.RentalTableAdapter RentalAdapter = new VideoCls.DAL.AdminDataTableAdapters.RentalTableAdapter();
            VideoCls.Class.ClientCls mCliente = new VideoCls.Class.ClientCls();
            decimal valor;
            
            try
            {
                mRental.IdClient = Convert.ToInt32(cbIdCliente.SelectedValue);
                mRental.DateRent = DateTime.Now;
                mRental.DateVencimineto = Convert.ToDateTime(dtFecha.Text.ToString());
                mRental.Idsucursal = 1;
                mRental.IdPelicula = Convert.ToInt32(cbIdPelicula.SelectedValue);
                mRental.Total = mCliente.ObtenerTotal(Convert.ToInt32(cbIdCliente.SelectedValue));
                mCliente.UpdateQtyCliente(Convert.ToInt32(cbIdCliente.SelectedValue));
                valor= mCliente.ObtenerTotal(Convert.ToInt32(cbIdCliente.SelectedValue));

                if ((MessageBox.Show("Seguro que desea registrar renta? " +
                " El valor de la renta es de: " + valor +"", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    if (mRental.InsertRent() == true)
                    {
                        GridRentas.DataSource = null;
                        GridRentas.DataSource = mRental.ListRent();
                        GridRentas.Refresh();
                        btnLista.Enabled = true;
                        cbBuscar.Enabled = true;
                        btnBuscar.Enabled = true;
                        cbIdCliente.Enabled = false;
                        cbIdPelicula.Enabled = false;
                        cbIdSucursal.Enabled = false;
                        dtFecha.Enabled = false;
                        btnOK.Enabled = false;
                        btnCancelar.Enabled = false;
                        MessageBox.Show("Se ha registrado la renta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El registro de la renta ha fallado, verifique los datos e intente de nuevo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Se ha producido un error");
            }
        }

        private void cbIdCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VideoCls.Class.RentalCls mRental = new VideoCls.Class.RentalCls();
            VideoCls.DAL.AdminDataTableAdapters.RentalTableAdapter RentalAdapter = new VideoCls.DAL.AdminDataTableAdapters.RentalTableAdapter();

            GridRentas.DataSource = null;
            mRental.IdRenta = Convert.ToInt32(cbBuscar.Text.ToString());
            GridRentas.DataSource = mRental.SearchRental();
            GridRentas.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnLista.Enabled = true;
            cbBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            cbIdCliente.Enabled = false;
            cbIdPelicula.Enabled = false;
            cbIdSucursal.Enabled = false;
            dtFecha.Enabled = false;
            btnOK.Enabled = false;
            btnCancelar.Enabled = false;
            cbIdCliente.ResetText();
            cbIdPelicula.ResetText();
            cbIdSucursal.ResetText();

        }
    }
}
