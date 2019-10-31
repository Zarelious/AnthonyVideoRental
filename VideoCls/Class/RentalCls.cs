using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    public class RentalCls
    {
        public int IdMovie { get; set; }
        public int IdClient { get; set; }
        public DateTime DateRent { get; set; }
        public DateTime DateVencimineto { get; set; }

        /// <summary>
        /// Para insertar una nueva renta
        /// </summary>
        /// <returns> true si fue insertada </returns>
        public bool InsertRent()
        {
            DAL.AdminDataTableAdapters.RentalTableAdapter mta = new DAL.AdminDataTableAdapters.RentalTableAdapter();

            try
            {
                mta.InsertQuery(IdMovie, IdClient, Convert.ToString(DateRent),  Convert.ToString(DateVencimineto));

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
    }
}
