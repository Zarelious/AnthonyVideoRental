using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class RentalCls
    {
        
        public int IdClient { get; set; }
        public DateTime DateRent { get; set; }
        public DateTime DateVencimineto { get; set; }
        public int IdRenta { get; set; }
        public int IdPelicula { get; set; }
        public decimal Total { get; set; }
        public int Idsucursal { get; set; }

        /// <summary>
        /// Para insertar una nueva renta
        /// </summary>
        /// <returns> true si fue insertada </returns>
        public bool InsertRent()
        {
            DAL.AdminDataTableAdapters.RentalTableAdapter mta = new DAL.AdminDataTableAdapters.RentalTableAdapter();

            try
            {
                mta.InsertQuery(IdClient,DateRent,DateVencimineto,Total,Idsucursal,IdPelicula);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// para mostrar la lista de rentas
        /// </summary>
        /// <returns> una list </returns>
        public DAL.AdminData.RentalDataTable ListRent()
        {
            DAL.AdminDataTableAdapters.RentalTableAdapter mta = new DAL.AdminDataTableAdapters.RentalTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.Fill(mds.Rental);

                return mds.Rental;
            }
            catch
            {
                return mds.Rental;
            }
        }

        /// <summary>
        /// lista con nombre no numeros
        /// </summary>
        /// <returns> lista completa </returns>
        public DAL.AdminData.RentalComDataTable ListRentCom()
        {
            DAL.AdminDataTableAdapters.RentalComTableAdapter mta = new DAL.AdminDataTableAdapters.RentalComTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.FillRentalCom(mds.RentalCom);

                return mds.RentalCom;
            }
            catch
            {
                return mds.RentalCom;
            }
        }

        public int CountMovie()
        {
            DAL.AdminDataTableAdapters.RentalTableAdapter mta = new DAL.AdminDataTableAdapters.RentalTableAdapter();

            try
            {
                return Convert.ToInt32(mta.AddQuery());

            }
            catch
            {
                return 0;
            }

        }
        public DAL.AdminData.RentalDataTable SearchRental()
        {
            DAL.AdminDataTableAdapters.RentalTableAdapter mta = new DAL.AdminDataTableAdapters.RentalTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();
            try
            {
                mta.FillByIdRenta(mds.Rental, IdRenta);

                if (mds.Rental.Rows.Count == 1)
                {
                    DAL.AdminData.RentalRow mrow = (DAL.AdminData.RentalRow)mds.Rental.Rows[0];

                    IdClient = mrow.IdClient;
                    DateRent = mrow.DateRent;
                    DateVencimineto = mrow.DateVencimiento;
                    IdRenta = mrow.IdRenta;
                    IdPelicula = mrow.IdPelicula;
                    Idsucursal = mrow.IdSucursal;
                    Total = mrow.Total;

                    return mds.Rental;
                }
                else
                {
                    return mds.Rental;
                }

            }
            catch
            {
                return mds.Rental;
            }
        }

    }
}
