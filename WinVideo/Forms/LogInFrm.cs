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
    public partial class LogInFrm : Form
    {
        public String mRespuesta = "";
        public LogInFrm()
        {
            InitializeComponent();

            userTxtBx.Text = "TheBoss";
            passwTxtBx.Text = "123456";
        }

        private void EnterBt_Click(object sender, EventArgs e)
        {
            VideoCls.Class.UserCls mUser = new VideoCls.Class.UserCls();
            mRespuesta = mUser.SearchUserAndPassword(userTxtBx.Text.ToString(), passwTxtBx.Text.ToString());
            switch (mRespuesta)
            {
                case "OK":
                    mRespuesta = "OK";
                    VideoCls.Class.StaticCls.UtilityClass.UserNameStatic = userTxtBx.Text.ToString();
                    this.Close();
                    break;
                case "NE":
                    var result = MessageBox.Show("El Usuario no Existe");
                    break;
                case "PNE":
                    var resultpne = MessageBox.Show("El Password no es Valido");
                    break;
                case "EC":
                    var resultEC = MessageBox.Show("Error de conexion");
                    break;
            }
            
        }

        private void LogInFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
