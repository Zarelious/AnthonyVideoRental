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
    public partial class AdminMovieFrm : Form
    {
        public AdminMovieFrm()
        {
            InitializeComponent();
        }

        private void AdminMovieFrm_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            VideoCls.Class.MovieCls mData = new VideoCls.Class.MovieCls();

            MovieGrdVw.DataSource = null;
            MovieGrdVw.DataSource = mData.ListMovies();
            MovieGrdVw.AutoResizeColumns();
            MovieGrdVw.Refresh();
        }

        private void SaveBt_Click(object sender, EventArgs e)
        {
            VideoCls.Class.MovieCls mtemp = new VideoCls.Class.MovieCls();

            mtemp.IdMovie = 1;
            mtemp.Name = MovieTxtBx.Text.Trim().ToString();
            mtemp.Clasificacion = ClassTxtBx.Text.Trim().ToString();
            mtemp.IdSucursal = 1;

            mtemp.Insert();

            LoadList();
        }
    }
}
