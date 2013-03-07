﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DNBSNData;

namespace DNBSNDb
{
    public class DbInteraction
    {
        static string passwordCurrent = "technicise";
        static string dbmsCurrent = "dnbsndb";

        private static MySql.Data.MySqlClient.MySqlConnection OpenDbConnection()
        {
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=" + passwordCurrent + ";database=" + dbmsCurrent + ";persist security info=False");

            //open the connection
            if (msqlConnection.State != System.Data.ConnectionState.Open)
                msqlConnection.Open();

            return msqlConnection;
        }

        #region User

        public static int DoRegisterNewUser(UserInfo NewUser)
        {
            return DoRegisterNewuserindb(NewUser);
        }

        private static int DoRegisterNewuserindb(UserInfo NewUser)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                msqlCommand.CommandText = "INSERT INTO user(id,userid,passwrd,hints) " + "VALUES(@id,@userid,@passwrd,@hints)";

                msqlCommand.Parameters.AddWithValue("@id", NewUser.id);
                msqlCommand.Parameters.AddWithValue("@userid", NewUser.userId);
                msqlCommand.Parameters.AddWithValue("@passwrd", NewUser.pass);
                msqlCommand.Parameters.AddWithValue("@hints", NewUser.hints);


                msqlCommand.ExecuteNonQuery();

                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        #endregion

        //#region Note

        //public static int DoEnterNewNote(UserInfo NewUser)
        //{
        //    return DoEnterNewNoteindb(NewUser);
        //}

        //private static int DoRegisterNewuserindb(UserInfo NewUser)
        //{
        //    int returnVal = 0;
        //    MySql.Data.MySqlClient.MySqlConnection msqlConnection = OpenDbConnection();

        //    try
        //    {
        //        //define the command reference
        //        MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

        //        //define the connection used by the command object
        //        msqlCommand.Connection = msqlConnection;

        //        msqlCommand.CommandText = "INSERT INTO user(id,userid,passwrd,hints) " + "VALUES(@id,@userid,@passwrd,@hints)";

        //        msqlCommand.Parameters.AddWithValue("@id", NewUser.id);
        //        msqlCommand.Parameters.AddWithValue("@userid", NewUser.userId);
        //        msqlCommand.Parameters.AddWithValue("@passwrd", NewUser.pass);
        //        msqlCommand.Parameters.AddWithValue("@hints", NewUser.hints);


        //        msqlCommand.ExecuteNonQuery();

        //        returnVal = 1;
        //    }
        //    catch (Exception er)
        //    {
        //        returnVal = 0;
        //    }
        //    finally
        //    {
        //        //always close the connection
        //        msqlConnection.Close();
        //    }
        //    return returnVal;
        //}

        //#endregion
    }
}
