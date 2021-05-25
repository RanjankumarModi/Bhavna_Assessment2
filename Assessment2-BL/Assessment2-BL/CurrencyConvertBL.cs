using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Assessment2_BL
{
    public static class CurrencyConvertBL
    {
        private static List<ConversionList> list = new List<ConversionList>();

        public static List<ConversionList> List { get => list; set => list = value; }

        #region Add currencies to database 
        /// <summary>
        /// Add currencies to database
        /// </summary>
        /// <param name="list"></param>
        public static void AddCurrencyToDatabase(List<ConversionList> list)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Currency; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("insert into Currency(currencySymbol,currencyValue)values(@currencySymbol,@currencyValue);", sqlConnection);
                sqlConnection.Open();
                foreach(var tempList in list)
                {
                    cm.Parameters.AddWithValue("@currencySymbol",tempList.Currencyname);
                    cm.Parameters.AddWithValue("@currencyValue",tempList.Exchangevalue);
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while inserting data: {e.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion

        #region delete currencies from database
        /// <summary>
        /// Delete data from Database
        /// </summary>
        public static void DeleteCurrenciesFromDatabase()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Currency; integrated security=SSPI");
                SqlCommand sqlCommand = new SqlCommand("delete from currency;", sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while deleting data: {e.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        #endregion

        

        #region GetList from Databse
        /// <summary>
        /// takes out the data from database
        /// </summary>
        public static List<ConversionList> GetlistFromDatabase()
        {
            SqlConnection sqlConnection = null;
            
            // List<Currency> currencies = new List<Currency>();

            try
            {
                sqlConnection = new SqlConnection("data source=.; database=Currency; integrated security=SSPI");
                SqlCommand sqlCommand = new SqlCommand("select * from currency;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

               
                while (sqlDataReader.Read())
                {
                    
                    string name = sqlDataReader["currencySymbol"].ToString();
                    
                    float rate = float.Parse(sqlDataReader["currencyValue"].ToString());
                    //Console.WriteLine(rate);
                    List.Add(new ConversionList(name,rate));
                }
            }
            catch (Exception e)
            {
             //   Console.WriteLine("Example");
                Console.WriteLine($"Exception occured while retrieving data: {e.Message}");
            }
            finally
            {
                sqlConnection.Close();
            }
            return list;
        }
        #endregion

        #region AddCurrencies to list then to database
        /// <summary>
        /// AddCurrencies to list and then call function that add to  database
        /// </summary>
        public static void AddCurrencies()
        {
            //List<ConversionList> list= new List<ConversionList>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Currency name: ");
                string name = Console.ReadLine().ToUpper();
                while (List.Any(c => c.Currencyname.Equals(name)))
                {
                    Console.WriteLine("This Currency already present please enter another!");
                    Console.Write("Currency name: ");
                    name = Console.ReadLine();
                }

                
                Console.Write("Conversion rate: ");
                float rate;

                while (!float.TryParse(Console.ReadLine(), out rate))
                {
                    Console.WriteLine("Enter valid rate");
                }
                List.Add(new ConversionList(name, rate));
            }
           AddCurrencyToDatabase(List);
        }
        #endregion

        #region Calculate currency
        /// <summary>
        /// Calculate Currency Function
        /// </summary>
        /// <returns> Float value in Indian currency</returns>
        public static float CalculateCurrency()
        {
            List.RemoveAll(item=>item.Exchangevalue!=0);
            GetlistFromDatabase();
            List<string> strSymbol = new List<string>();
            //Console.WriteLine(List.Count());
            foreach (var item in List)
            {
                Console.WriteLine(item.Currencyname+"   "+item.Exchangevalue);
                strSymbol.Add(item.Currencyname); 
            }
            float x = 0.0f;
            try
            {
                Console.Write("Enter currency symbol (eg. EURINR): ");
                string currencySymbol = Console.ReadLine().ToUpper();

                
                while (!strSymbol.Contains(currencySymbol))
                {
                    Console.Write("This Currency is not present please enter another (eg. EURINR): ");
                    currencySymbol = Console.ReadLine().ToUpper();
                   
                }

                Console.Write("Enter Amount: ");
                double amount;

                while (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.Write("Please enter a valid amount: ");
                }

                foreach(var templist in List)
                {
                    if(templist.Currencyname.Equals(currencySymbol))
                    {
                        x = (float)((templist.Exchangevalue) * amount);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured while calculating amount: {e.Message}");
            }
            return x;
        }
        #endregion
    }


    #region Conversion class for list
    /// <summary>
    /// Conversion class
    /// </summary>
    public class ConversionList
    {
        private string currencyname;
        private float exchangevalue;

        public ConversionList(string currencyname, float exchangevalue)
        {
            this.currencyname = currencyname;
            this.exchangevalue = exchangevalue;
        }

        public string Currencyname { get => currencyname; set => currencyname = value; }
        public float Exchangevalue { get => exchangevalue; set => exchangevalue = value; }
    }
    #endregion
}
