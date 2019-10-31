using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VideoCls.Class
{
    public class ClientCls
    {
        public int IdClient { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String email { get; set; }
        public String tele { get; set; }
        public DateTime DOB { get; set; }
        public String Status { get; set; }
        public String Address { get; set; }
        public String ProofOfId { get; set; }
        public int IdSucursal { get; set; }
        public int Qty { get; set; }

        public decimal Total { get; set; }
        /// <summary>
        /// Para llamar una list de clientes
        /// </summary>
        /// <returns> la lista de clientes </returns>
        public DAL.AdminData.ClientDataTable ListClient()
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.Fill(mds.Client);

                return mds.Client;
            }
            catch
            {
                return mds.Client;
            }
        }

        /// <summary>
        /// para buscar un cliente specifico
        /// </summary>
        /// <returns>la informacion de un cliente</returns>
        public DAL.AdminData.ClientDataTable SearchClient()
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.FillByIdClient(mds.Client, IdClient);

                if (mds.Client.Rows.Count == 1)
                {
                    DAL.AdminData.ClientRow mrow = (DAL.AdminData.ClientRow)mds.Client.Rows[0];

                    IdClient = mrow.IdClient;
                    FirstName = mrow.FirstName;
                    LastName = mrow.LastName;
                    email = mrow.email;
                    tele = mrow.telefone;
                    DOB = mrow.DOB;
                    Status = mrow.Status;
                    Address = mrow.Address;
                    ProofOfId = mrow.ProoOfId;
                    IdSucursal = mrow.Idsucursal;
                    Qty = mrow.Qty;

                    return mds.Client;

                }
                else
                {
                    return mds.Client;
                }
            }
            catch
            {
                return mds.Client;
            }
        }

        /// <summary>
        /// para insertar un nuevo cliente
        /// </summary>
        /// <returns> regresa true si lo cambio</returns>
        public bool InsertClient()
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            try
            {
                mta.InsertQuery(FirstName, LastName, email, tele, Convert.ToString(DOB), Status, Address, ProofOfId, Qty, IdSucursal);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// para cambiar la informacion del cliente
        /// </summary>
        /// <returns>regresa true si lo cambio</returns>
        public bool UpdateClient()
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            try
            {
                mta.UpdateQuery(FirstName, LastName, email, tele, Convert.ToString(DOB), Status, Address, ProofOfId, IdSucursal, Qty, IdClient);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteClient()
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            try
            {
                mta.DeleteQuery(IdClient);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public decimal ObtenerTotal(int vIdCliente)
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();


            mta.FillByIdClient(mds.Client, vIdCliente);

            if (mds.Client.Rows.Count == 1)
            {
                DAL.AdminData.ClientRow mrow = (DAL.AdminData.ClientRow)mds.Client.Rows[0];

                IdClient = mrow.IdClient;
                Qty = mrow.Qty;
                if (Qty != 0 && Qty % 5 == 0)
                {
                    return 0;
                }

                else
                {
                    return 1000;
                }
            }
            else
            {
                return -1;
            }


        }

        public bool UpdateQtyCliente(int vIdCliente)
        {
            DAL.AdminDataTableAdapters.ClientTableAdapter mta = new DAL.AdminDataTableAdapters.ClientTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();


            mta.FillByIdClient(mds.Client, vIdCliente);

            if (mds.Client.Rows.Count == 1)
            {
                DAL.AdminData.ClientRow mrow = (DAL.AdminData.ClientRow)mds.Client.Rows[0];

                Qty = mrow.Qty;
                mta.UpdateQty((Qty + 1),vIdCliente);
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}
