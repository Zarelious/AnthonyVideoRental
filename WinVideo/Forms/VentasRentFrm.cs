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
    public partial class VentasRentFrm : Form
    {
        public VentasRentFrm()
        {
            InitializeComponent();
        }

        private void VentasRentFrm_Load(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            cbIdPelicula.DisplayMember = "Name";
            cbIdPelicula.ValueMember = "IdMovie";
            cbIdPelicula.DataSource = mMovie.ListMovies();

            VideoCls.Class.ClientCls mClient = new VideoCls.Class.ClientCls();
            cbCliente.DisplayMember = "LastName";
            cbCliente.ValueMember = "IdClient";
            cbCliente.DataSource = mClient.ListClient();

        }
    }
}
