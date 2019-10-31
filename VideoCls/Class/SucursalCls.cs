using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class SucursalCls
    {
        public int IdSucursal { get; set; }
        public String Name { get; set; }


        /// <summary>
        /// Lista de usuarios
        /// </summary>
        /// <returns> lista de usuarios</returns>
        public DAL.AdminData.SucursalDataTable ListSucursal()
        {
            DAL.AdminDataTableAdapters.SucursalTableAdapter mta = new DAL.AdminDataTableAdapters.SucursalTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.Fill(mds.Sucursal);

                return mds.Sucursal;
            }
            catch
            {
                return mds.Sucursal;
            }
        }
    }
}
