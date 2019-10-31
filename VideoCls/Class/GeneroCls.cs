using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class GeneroCls
    {
        public int IdMovie { get; set; }
        public int IdGenero { get; set; }
        
        /// <summary>
        /// Para llamar los Table Adapters
        /// </summary>
        DAL.AdminDataTableAdapters.MovieGenroTableAdapter mta = new DAL.AdminDataTableAdapters.MovieGenroTableAdapter();
        DAL.AdminData mds = new DAL.AdminData();

        /// <summary>
        /// para insertar un nuevo Genero 
        /// </summary>
        /// <returns>true  si fue ingresado correctamente</returns>
        public bool Insert()
        {
            try
            {
                mta.InsertQuery(IdMovie, IdGenero);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// List de todos los generos de la peliculas
        /// </summary>
        /// <returns></returns>
        public DAL.AdminData.MovieGenroDataTable ListAll()
        {
            try
            {
                mta.Fill(mds.MovieGenro);
                return mds.MovieGenro;
            }
            catch
            {
                return mds.MovieGenro;
            }
        }

        public bool Update()
        {
            try
            {
                mta.UpdateQuery(IdGenero, IdMovie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete()
        {
            mta.DeleteQuery(IdMovie);
            return true;
        }
        

    }
}
