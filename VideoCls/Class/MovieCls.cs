using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VideoCls.Class
{
    public class MovieCls
    {
        public int IdMovie { get; set; }
        public String Name { get; set; }
        public String Clasificacion { get; set; }
        public int IdSucursal { get; set; }

        // Para insertar una nueva pelicula
        public bool Insert()
        {
            try
            {
                DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

                mta.InsertQuery(Name, Clasificacion, IdSucursal);

                return true;
            }
            catch
            {
                return false;            
            }
        }

        // Para ver una lista de pelicula
        public DAL.AdminData.MovieDataTable ListMovies()
        {
            DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.Fill(mds.Movie);
                return mds.Movie;
            }
            catch
            {
                return mds.Movie;
            }
        }

        // Para ver una lista de pelicula completa
        public DAL.AdminData.ComleteMoviDataTable ListCompletaMovies()
        {
            DAL.AdminDataTableAdapters.ComleteMoviTableAdapter mta = new DAL.AdminDataTableAdapters.ComleteMoviTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.FillCom(mds.ComleteMovi);
                return mds.ComleteMovi;
            }
            catch
            {
                return mds.ComleteMovi;
            }
        }

        // Para borrar una pelicula
        public bool Delete()
        {
            DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

            try
            {
                mta.DeleteQuery(IdMovie);

                return true;
            }
            catch
            {
                return false;
            }
        }

        // Para actualizar un dato
        public bool Update()
        {
            {
                DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

                try
                {
                    mta.UpdateQuery(Name, Clasificacion, IdSucursal, IdMovie);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        // Para llamar una pelicula
        public DAL.AdminData.MovieDataTable ListOneMovie()
        {
            DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.FillByIdMovie(mds.Movie, IdMovie);

                if (mds.Movie.Rows.Count == 1)
                {
                    DAL.AdminData.MovieRow mrow = (DAL.AdminData.MovieRow)mds.Movie.Rows[0];

                    IdMovie = mrow.IdMovie;
                    Name = mrow.Name;
                    Clasificacion = mrow.Classification;
                    IdSucursal = mrow.IdSucursal;


                    return mds.Movie;
                }
                else
                {
                    return mds.Movie;
                }
                
            }
            catch
            {
                return mds.Movie;
            }
        }
                
    }
}
