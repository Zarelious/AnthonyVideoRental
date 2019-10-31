using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class DevolucionesCls
    {
        public int IdPeliculas { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaDecolucion { get; set; }

        public int IdDevolucion { get; set; }

        /// <summary>
        /// Para llamar los Table Adapters
        /// </summary>
        DAL.AdminDataTableAdapters.DevolucionesTableAdapter mta = new DAL.AdminDataTableAdapters.DevolucionesTableAdapter();
        DAL.AdminData mds = new DAL.AdminData();


        public bool Insert()
        {
            try
            {
                mta.InsertQuery(IdCliente, IdPeliculas, FechaDecolucion);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// List de las devoluciones
        /// </summary>
        /// <returns></returns>
        public DAL.AdminData.DevolucionesDataTable ListAll()
        {
            try
            {
                mta.Fill(mds.Devoluciones);
                return mds.Devoluciones;
            }
            catch
            {
                return mds.Devoluciones;
            }
        }


        public DAL.AdminData.DevolucionesDataTable Search()
        {
          
                mta.FillByIdClienteIdPelicula(mds.Devoluciones, IdCliente, IdPeliculas);

                if (mds.Devoluciones.Rows.Count == 1)
                {
                    DAL.AdminData.DevolucionesRow mrow = (DAL.AdminData.DevolucionesRow)mds.Devoluciones.Rows[0];

                    IdPeliculas = mrow.IdPelicula;
                    IdCliente = mrow.IdCliente;
                    FechaDecolucion = mrow.FechaDevolucion;
                    
                    return mds.Devoluciones;
                }
                else
                {
                    return mds.Devoluciones;
                }

            
        }
        /// <summary>
        /// para actualizar la informacion
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            try
            {
                mta.UpdateQuery(FechaDecolucion, IdCliente, IdPeliculas);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
