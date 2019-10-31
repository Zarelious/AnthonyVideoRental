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
    public partial class MainMenuFrm : Form
    {
        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuFrm_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadDataGrid();

        }

        private void loadCombo()
        {
            VideoCls.Class.MovieCls mClass = new VideoCls.Class.MovieCls();
            cbClasificacion.DisplayMember = "Classification";
            cbClasificacion.ValueMember = "IdMovie";
            cbClasificacion.DataSource = mClass.ListMovies();

            VideoCls.Class.SucursalCls mSuc = new VideoCls.Class.SucursalCls();
            cbSucursal.DisplayMember = "Name";
            cbSucursal.ValueMember = "IdSucursal";
            cbSucursal.DataSource = mSuc.ListSucursal();
        }

        private void loadDataGrid()
        {
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            GridPeliculas.DataSource = null;
            GridPeliculas.DataSource = mMovie.ListCompletaMovies();
            GridPeliculas.AutoResizeColumns();
            GridPeliculas.Refresh();
        }
    }
}
