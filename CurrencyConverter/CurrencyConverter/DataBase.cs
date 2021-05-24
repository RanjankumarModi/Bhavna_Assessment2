//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CurrencyConverter
//{
//    class DataBase
//    {
        

//        #region Insert In DB
        
//        #endregion

//        #region Search Method
//        /// <summary>
//        /// Method to search currency from data bade and convert
//        /// </summary>
//        /// <param name="currencySymbol"></param>
//        /// <param name="Value"></param>
//        /// <returns>Rupee valuereturns>
//        public void SearchCurrency(string currencySymbol, float Value)
//        {
//            //SqlConnection con = null;
//            float rupee = float.MinValue;
//            SqlConnection sqlConnection = null;
//            List<ConversionList> list = new List<ConversionList>();

//            try
//            {
//                sqlConnection = new SqlConnection("data source=.; database=Currency; integrated security=SSPI");
//                SqlCommand sqlCommand = new SqlCommand("select * from currency;", sqlConnection);
//                sqlConnection.Open();
//                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

//                while (sqlDataReader.Read())
//                {
//                   // ConversionList currency = new ConversionList();
//                    if(currencySymbol.Equals( sqlDataReader["currencySymbol"].ToString()))
//                   rupee=Value*(float.Parse(sqlDataReader["currencyValue"].ToString()));
//                    // currencies.Add(currency);
//                    Console.WriteLine(rupee);
//                    return ;
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine($"Exception occured while retrieving data: {e.Message}");
//            }
//            finally
//            {
//                sqlConnection.Close();
//            }

//          //  return currencies;
            
//        }
//        #endregion

//        #region
//        /// <summary>
//        /// Delete existing record
//        /// </summary>
//        public void Delete()
//        {
//            SqlConnection con = null;
            
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=.; database=Currency; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("Delete from Currency;", con);
//                // Opening Connection  
//                con.Open();
                

//                // Executing the SQL query  
//                SqlDataReader sdr = cm.ExecuteReader();
    
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong." + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//        #endregion
//    }

//    internal class ConversionList
//    {
//    }
//}
