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
        public DAL.AdminData.MovieDataTable SearchMovie()
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

       
        /// <summary>
        /// List of Generos
        /// </summary>
        /// <returns>returns the a list Generos</returns>
        public DAL.AdminData.GeneroDataTable ListGenero()
        {
            DAL.AdminDataTableAdapters.GeneroTableAdapter mta = new DAL.AdminDataTableAdapters.GeneroTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.Fill(mds.Genero);
                return mds.Genero;
            }
            catch
            {
                return mds.Genero;
            }
        }

        /// <summary>
        /// List of all formats
        /// </summary>
        /// <returns>returns a list</returns>
        public DAL.AdminData.FormatDataTable ListFormat()
        {
            DAL.AdminDataTableAdapters.FormatTableAdapter mta = new DAL.AdminDataTableAdapters.FormatTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.Fill(mds.Format);
                return mds.Format;
            }
            catch
            {
                return mds.Format;
            }
        }

        /// <summary>
        /// Buscar Peliculas por Nombre
        /// </summary>
        /// <returns>la informacion de la pelicula </returns>
        public DAL.AdminData.MovieDataTable SearchMovieName(String mName)
        {
            DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.FillByName(mds.Movie, mName);

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
        public Boolean SearchMovieNameBool(String mName)
        {
            DAL.AdminDataTableAdapters.MovieTableAdapter mta = new DAL.AdminDataTableAdapters.MovieTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.FillByName(mds.Movie, mName);

                if (mds.Movie.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
