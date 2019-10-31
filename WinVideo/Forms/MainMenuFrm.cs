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
        String mverify = "";

        public MainMenuFrm()
        {
            InitializeComponent();
        }

        public int vControl { get; set; }
        public int vEditControl { get; set; }
        public int tempIndex { get; set; }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            VideoCls.Class.UserCls mUser = new VideoCls.Class.UserCls();
            mverify = mUser.ConfirmStatus();
            switch (mverify)
            {
                case "OK":
                    WinVideo.Forms.AdminClientesFrm vCliente = new AdminClientesFrm();
                    vCliente.Show();
                    break;
                case "PNA":
                    var resultpne = MessageBox.Show("El Usuario no esta Activo");
                    break;
                case "EC":
                    var resultEC = MessageBox.Show("Error de conexion");
                    break;
            }
        }

        private void MainMenuFrm_Load(object sender, EventArgs e)
        {
            Forms.LogInFrm mLogin = new LogInFrm();
            mLogin.ShowDialog();
            if (mLogin.mRespuesta.Trim() != "OK")
            {
                this.Close();
            }
            loadCombo();
            fieldDisable();
            showFlields();
            loadDataGridMovCom();
            

        }

        private void loadCombo()
        {
           
            VideoCls.Class.MovieCls movieCls = new VideoCls.Class.MovieCls();
            cbFormat.DisplayMember = "Type";
            cbFormat.ValueMember = "IdFormat";
            cbFormat.DataSource = movieCls.ListFormat();

            cbGenero.DisplayMember = "Type";
            cbGenero.ValueMember = "IdGenero";
            cbGenero.DataSource = movieCls.ListGenero();
                      


        }

        private void loadDataGridMovCom()
        {
            GridPeliculas.DataSource = null;
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            GridPeliculas.DataSource = mMovie.ListCompletaMovies();
            GridPeliculas.AutoResizeColumns();
            GridPeliculas.Refresh();

            
        }

        private void btnListaPeliculas_Click(object sender, EventArgs e)
        {
            loadDataGridMovCom();
        }

        private void btnListaFormatos_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            vControl = 1;
            showFlields();
            fieldEnable();
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            txtID.Visible = false;
            labelID.Visible = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            VideoCls.Class.MoveFormatCls mFormat = new VideoCls.Class.MoveFormatCls();
            VideoCls.Class.GeneroCls mGenero = new VideoCls.Class.GeneroCls();

            

            if (vControl == 1)
            {
                mMovie.Name = txtNombreP.Text.ToString();
                mMovie.Clasificacion = cbClasificacion.Text.ToString();
                mMovie.IdSucursal = 1;
                mFormat.IdFormat = Convert.ToInt32(cbFormat.SelectedValue);
                mGenero.IdGenero = Convert.ToInt32(cbGenero.SelectedValue);
                mFormat.Qty = Convert.ToInt32(QtyTxtBx.Value);

                if (mMovie.SearchMovieNameBool(txtNombreP.Text) == true)
                {
                    mMovie.SearchMovieName(txtNombreP.Text.ToString());
                    mFormat.IdMovie = mMovie.IdMovie;
                    mFormat.Insert();
                    cancelarTodo();
                    loadDataGridMovCom();
                    MessageBox.Show("Exito");
                }
                else
                {
                    if (mMovie.Insert() == true)
                    {

                        mMovie.SearchMovieName(txtNombreP.Text.ToString());
                        mFormat.IdMovie = mMovie.IdMovie;
                        mGenero.IdMovie = mMovie.IdMovie;
                        if (mFormat.Insert() == true && mGenero.Insert() == true)
                        {
                            cancelarTodo();
                            loadDataGridMovCom();
                            MessageBox.Show("Exito");
                        }
                        else
                        {
                            loadDataGridMovCom();
                            MessageBox.Show("Fallo");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Fallo");
                    }
                }
            }
            else if (vControl == 2)
            {
                mMovie.IdMovie = int.Parse(txtID.Text.ToString());
                mMovie.Name = txtNombreP.Text.ToString();
                mMovie.Clasificacion = cbClasificacion.Text.ToString();
                mMovie.IdSucursal = 1;

                if (vEditControl == 1)
                {
                    if (mMovie.Update() == true)
                    {
                        cancelarTodo();
                        loadDataGridMovCom();
                        MessageBox.Show("Exito");
                    }
                    else
                    {
                        loadDataGridMovCom();
                        MessageBox.Show("Fallo");
                    }



                }
                else if (vEditControl == 2)
                {
                    mMovie.SearchMovieName(txtNombreP.Text.ToString());
                    mGenero.IdMovie = mMovie.IdMovie;
                    if (mGenero.Update() == true)
                    {
                        cancelarTodo();
                        loadDataGridMovCom();
                        MessageBox.Show("Exito");
                    }
                    else
                    {
                        loadDataGridMovCom();
                        MessageBox.Show("Fallo");
                    }
                }
                else if (vEditControl == 3)
                {
                    mMovie.SearchMovieName(txtNombreP.Text.ToString());
                    mFormat.IdMovie = mMovie.IdMovie;
                    mFormat.IdFormat = int.Parse(cbFormat.SelectedValue.ToString());
                    mFormat.Qty = Int16.Parse(QtyTxtBx.Value.ToString());
                    if (mFormat.Update() == true)
                    {
                        cancelarTodo();
                        loadDataGridMovCom();
                        MessageBox.Show("Exito");
                    }
                    else
                    {
                        loadDataGridMovCom();
                        MessageBox.Show("Fallo");
                    }
                }
            }
            else if (vControl == 3)
            {
                mMovie.IdMovie = Convert.ToInt32(txtID.Text.ToString());
                mGenero.IdMovie = Convert.ToInt32(txtID.Text.ToString());
                mFormat.IdMovie = Convert.ToInt32(txtID.Text.ToString());
                mFormat.IdFormat = Convert.ToInt32(cbFormat.SelectedValue);
                if (mGenero.Delete() == true)
                {
                    if (mFormat.Delete() == true)
                    {
                        if (mMovie.Delete() == true)
                        {
                            loadDataGridMovCom();
                            MessageBox.Show("Éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
            else if (vControl == 4)
            {
                mMovie.IdMovie = int.Parse(txtID.Text.ToString());
                mMovie.Name = txtNombreP.Text.Trim();
                //mMovie.SearchMovieName(txtNombreP.Text.Trim());
                
                GridPeliculas.DataSource = mMovie.SearchMovieName(txtNombreP.Text.Trim());
                txtID.Value = mMovie.IdMovie;
                txtNombreP.Text = mMovie.Name;
                cbClasificacion.Text = mMovie.Clasificacion;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelarTodo();
        }
                                           
        private void btnEditar_Click(object sender, EventArgs e)
        {
            vControl = 2;
            vEditControl = 1;
            cancelarTodo();
            showFlields();
            fieldDisable();
            txtID.Enabled = true;
            txtNombreP.Enabled = true;
            cbClasificacion.Enabled = true;
            
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void btnBuscarPeli_Click(object sender, EventArgs e)
        {
            vControl = 4;
            cancelarTodo();
            showFlields();
            
            btnGuardar.Text = "Buscar";
            QtyTxtBx.Enabled = false;
            txtNombreP.Enabled = true;
            cbClasificacion.Enabled = false;
            cbFormat.Enabled = false;
            cbGenero.Enabled = false;

            btnGuardar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vControl = 3;
            cancelarTodo();
            fieldDisable();
            txtID.Enabled = true;
            txtNombreP.Visible = true;
            labelNombreP.Visible = true;
            txtNombreP.Enabled = true;
            labelNombreP.Enabled = true;
            txtID.Visible = true;
            labelID.Visible = true;
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnGuardar.Text = "Eliminar";
        }

        private void loadDataMovBasic()
        {
            VideoCls.Class.MovieCls mMovie = new VideoCls.Class.MovieCls();
            GridPeliculas.DataSource = null;
            GridPeliculas.DataSource = mMovie.ListMovies();
            GridPeliculas.AutoResizeColumns();
            GridPeliculas.Refresh();
        }

        private void showFlields()
        {
            labelNombreP.Visible = true;
            labelClasificacion.Visible = true;
            labelGenero.Visible = true;
            cbFormat.Visible = true;
            cbGenero.Visible = true;
            txtNombreP.Visible = true;
            cbClasificacion.Visible = true;
            txtID.Visible = true;
            labelID.Visible = true;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            btnBuscar.Visible = false;
            QtyLabel.Visible = true;
            QtyTxtBx.Visible = true;
            btnGuardar.Text = "Guardar";

            
        }

        private void cancelarTodo()
        {
            labelNombreP.Visible = false;
            labelClasificacion.Visible = false;
            txtNombreP.Visible = false;
            cbClasificacion.Visible = false;
            btnBuscar.Visible = false;
            labelFormato.Visible = false;
            labelGenero.Visible = false;
            cbFormat.Visible = false;
            cbGenero.Visible = false;
            btnGuardar.Text = "Guardar";

            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            txtID.Visible = false;
            labelID.Visible = false;
            QtyTxtBx.Visible = false;
            QtyLabel.Visible = false;
        }

        private void BtnEditarGenero_Click(object sender, EventArgs e)
        {
            vControl = 2;
            vEditControl = 2;
            cancelarTodo();
            showFlields();
            fieldDisable();
            labelID.Visible = true;
            txtID.Visible = true;
            
            cbGenero.Enabled = true;

            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void BtnEditarFormat_Click(object sender, EventArgs e)
        {
            vControl = 2;
            vEditControl = 3;
            cancelarTodo();
            showFlields();
            fieldDisable();
            QtyTxtBx.Enabled = true;
            cbFormat.Enabled = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;

        }

        private void fieldDisable()
        {
            QtyTxtBx.Enabled = false;
            txtNombreP.Enabled = false;
            cbClasificacion.Enabled = false;
            cbFormat.Enabled = false;
            cbGenero.Enabled = false;
            txtID.Enabled = false;
        }

        private void fieldEnable()
        {
            QtyTxtBx.Enabled = true;
            txtNombreP.Enabled = true;
            cbClasificacion.Enabled = true;
            cbFormat.Enabled = true;
            cbGenero.Enabled = true;
            txtID.Enabled = true;
        }

        private void btnRenta_Click(object sender, EventArgs e)
        {
            VideoCls.Class.UserCls mUser = new VideoCls.Class.UserCls();
            mverify = mUser.ConfirmStatus();
            switch (mverify)
            {
                case "OK":
                    Forms.RentasFrm vRenta = new RentasFrm();
                    vRenta.Show();
                    break;
                case "PNA":
                    var resultpne = MessageBox.Show("El Usuario no esta Activo");
                    break;
                case "EC":
                    var resultEC = MessageBox.Show("Error de conexion");
                    break;
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            VideoCls.Class.UserCls mUser = new VideoCls.Class.UserCls();
            mverify = mUser.ConfirmStatus();
            switch (mverify)
            {
                case "OK":
                    Forms.Devoluciones devoluciones = new Devoluciones();
                    devoluciones.Show();
                    break;
                case "PNA":
                    var resultpne = MessageBox.Show("El Usuario no esta Activo");
                    break;
                case "EC":
                    var resultEC = MessageBox.Show("Error de conexion");
                    break;
            }

            
        }
    }
}
