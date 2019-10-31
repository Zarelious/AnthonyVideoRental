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
    public partial class Devoluciones : Form
    {
        public Devoluciones()
        {
            InitializeComponent();
        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataVidDataSet.Movie' Puede moverla o quitarla según sea necesario.
            //this.movieTableAdapter.Fill(this.dataVidDataSet.Movie);
            // TODO: esta línea de código carga datos en la tabla 'dataVidDataSet1.Client' Puede moverla o quitarla según sea necesario.
            //this.clientTableAdapter.Fill(this.dataVidDataSet1.Client);
            loadComboBx();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCls.Class.DevolucionesCls devolucionesCls = new VideoCls.Class.DevolucionesCls();
            if (MessageBox.Show("Seguro que desea registrar la informacion?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    devolucionesCls.IdCliente = Convert.ToInt32(cbId.SelectedValue);
                    devolucionesCls.IdPeliculas = Convert.ToInt32(cbPelicula.SelectedValue);
                    devolucionesCls.FechaDecolucion = DateTime.Today;
                    devolucionesCls.Insert();
                    MessageBox.Show("Se ha guardado exitosamente");
                    GridDevoluciones.DataSource = null;
                    GridDevoluciones.DataSource = devolucionesCls.ListAll();
                    GridDevoluciones.Refresh();
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error");
                }
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            VideoCls.Class.DevolucionesCls devolucionesCls = new VideoCls.Class.DevolucionesCls();
            try
            {
                devolucionesCls.IdCliente = Convert.ToInt32(cbId.SelectedValue);
                devolucionesCls.IdPeliculas = Convert.ToInt32(cbPelicula.SelectedValue);
                devolucionesCls.Search();
                GridDevoluciones.DataSource = null;
                GridDevoluciones.DataSource = devolucionesCls.Search();
                GridDevoluciones.Refresh();
            }
            catch
            {
                MessageBox.Show("Error al buscar infromacion, verifique los datos");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VideoCls.Class.DevolucionesCls devolucionesCls = new VideoCls.Class.DevolucionesCls();
            if (MessageBox.Show("Seguro que desea actualizar la informacion?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    devolucionesCls.IdCliente = Convert.ToInt32(cbId.SelectedValue);
                    devolucionesCls.IdPeliculas = Convert.ToInt32(cbPelicula.SelectedValue);
                    devolucionesCls.FechaDecolucion = DateTime.Today;
                    devolucionesCls.Update();
                    MessageBox.Show("Se ha actualizado con exito");

                    GridDevoluciones.DataSource = null;
                    GridDevoluciones.DataSource = devolucionesCls.ListAll();
                    GridDevoluciones.Refresh();
                }
                catch
                {
                    MessageBox.Show("Se ha producido un error");
                }
            }
        }

        private void loadComboBx()
        {
            VideoCls.Class.ClientCls clientCls = new VideoCls.Class.ClientCls();
            cbId.DisplayMember = "FirstName";
            cbId.ValueMember = "IdClient";
            cbId.DataSource = clientCls.ListClient();
            
            VideoCls.Class.MovieCls movieCls = new VideoCls.Class.MovieCls();
            cbPelicula.DisplayMember = "Name";
            cbPelicula.ValueMember = "IdMovie";
            cbPelicula.DataSource = movieCls.ListMovies();
        }
    }
}
