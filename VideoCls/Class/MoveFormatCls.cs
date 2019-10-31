using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class MoveFormatCls
    {
        public int IdFormat { get; set; }
        public int IdMovie { get; set; }
        public int Qty { get; set; }

        /// <summary>
        /// Calls to access the tada tables
        /// </summary>
        DAL.AdminDataTableAdapters.MovieFormatTableAdapter mta = new DAL.AdminDataTableAdapters.MovieFormatTableAdapter();
        DAL.AdminData mds = new DAL.AdminData();

        /// <summary>
        ///  para ingressar un nuevo formatod de pelicula
        /// </summary>
        /// <returns> true si lo ingreso correctamente</returns>
        public bool Insert()
        {
            try
            {
                mta.InsertQuery(IdMovie, IdFormat, Qty);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// para actualizar la informacion
        /// </summary>
        /// <returns> true si fue acftualizado corretamente</returns>
        public bool Update()
        {
            try
            {
                mta.UpdateQuery(Qty, IdMovie, IdFormat);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// para borrar la cantidad
        /// </summary>
        /// <returns> true si fue borrada correctamente</returns>
        public bool Delete()
        {
            try
            {
                mta.DeleteQuery(IdMovie, IdFormat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lista de todos los generos
        /// </summary>
        /// <returns></returns>
        public DAL.AdminData.MovieFormatDataTable ListAll()
        {
            try
            {
                mta.Fill(mds.MovieFormat);
                return mds.MovieFormat;
            }
            catch
            {
                return mds.MovieFormat;
            }
        }

            
    }
}
