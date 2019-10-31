using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCls.Class
{
    class UserCls
    {
        public int IdUser { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Profile { get; set; }
        public String Password { get; set; }
        public int IdSucursal { get; set; }
        public String UserName { get; set; }

        /// <summary>
        /// Lista de usuarios
        /// </summary>
        /// <returns> lista de usuarios</returns>
        public DAL.AdminData.UserDataTable ListUser()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.Fill(mds.User);

                return mds.User;
            }
            catch
            {
                return mds.User;
            }
        }

        /// <summary>
        /// un usuario
        /// </summary>
        /// <returns> un usuario </returns>
        public DAL.AdminData.UserDataTable SearchUser()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();

            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.FillByIdUser(mds.User, IdUser);

                if (mds.User.Rows.Count == 1)
                {
                    DAL.AdminData.UserRow mrow = (DAL.AdminData.UserRow)mds.User.Rows[0];

                    IdUser = mrow.IdUser;
                    FirstName = mrow.FirstName;
                    LastName = mrow.LastName;
                    Profile = mrow.Profile;
                    Password = mrow.Password;
                    IdSucursal = mrow.IdSucursal;

                    return mds.User;
                }
                else
                {
                    return mds.User;
                }

                
            }
            catch
            {
                return mds.User;
            }
        }

        /// <summary>
        /// Verificar el password
        /// </summary>
        /// <param name="vIdUsuario"></param>
        /// <param name="VPassword"></param>
        /// <returns></returns>
        public String SearchUserAndPassword(String vIdUsuario, String VPassword)
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();
            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.FillByIdUser(mds.User, IdUser);
                if (mds.User.Rows.Count == 1)
                {
                    DAL.AdminData.UserRow mUsuario = (DAL.AdminData.UserRow)mds.User.Rows[0];
                    if (VPassword.Trim() == mUsuario.Password.Trim())
                    {
                        return "OK";
                    }
                    else
                    {
                        return "PNE";
                    }
                }
                else
                {
                    return "NE";
                }
            }
            catch
            {
                return "EC";
            }
        }

        public String ConfirmStatus()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();
            DAL.AdminData mds = new DAL.AdminData();

            try
            {
                mta.FillByUserName(mds.User, StaticCls.UtilityClass.UserNameStatic);
                if (mds.User.Rows.Count == 1)
                {
                    DAL.AdminData.UserRow mUsuario = (DAL.AdminData.UserRow)mds.User.Rows[0];
                    if (mUsuario.Profile.Trim() == "Gerente")
                    {
                        return "OK";
                    }
                    else
                    {
                        return "PNA";
                    }
                }
                else
                {
                    return "PNA";
                }
            }
            catch
            {
                return "EC";
            }
        }

        /// <summary>
        /// Para insertar un nuevo usuario
        /// </summary>
        /// <returns>true si se pudo insertar</returns>
        public bool InsertUser()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();

            try
            {
                mta.InsertQuery(IdUser, UserName, FirstName, LastName, Profile, Password, IdSucursal);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Para actualizar un usuario
        /// </summary>
        /// <returns> true si fue actualizado</returns>
        public bool UpdateUser()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();

            try
            {
                mta.UpdateQuery(IdUser, UserName, FirstName, LastName, Profile, Password, IdSucursal, IdUser);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Para borrar un usuario
        /// </summary>
        /// <returns>delete para borrar</returns>
        public bool DeleteUser()
        {
            DAL.AdminDataTableAdapters.UserTableAdapter mta = new DAL.AdminDataTableAdapters.UserTableAdapter();

            try
            {
                mta.DeleteQuery(IdUser);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
