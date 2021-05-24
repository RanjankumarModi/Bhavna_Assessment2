using System;
using System.Collections.Generic;

namespace Assessment2_BL
{

        public static class CapitalizeFirstLetter
        {

        #region private Data Member
            /// <summary>
            /// Private data Member 
            /// Ignore list is used to match start of string
            /// </summary>
            public static List<string> ignoreList = new List<string>()
                                                  { "and", "or", "but", "nor", "yet", "so", "for", "a", "an", "the",
                                                    "in" , "to","of", "at", "by", "up", "for", "off", "on"
                                                   };
        #endregion

        #region Properties
        
        internal static List<string> IgnoreList { get => ignoreList; set => ignoreList = value; }
        #endregion


        #region Checks and capitalize word
        /// <summary>
        /// Method that check is a word is conjuction,articles and prteposition
        /// capitalize those are not conjuction,articles and prteposition
        /// </summary>
        /// <param name="capitalizeFirstLetter"></param>
        /// <returns></returns>
            public static string Check(string str)
            {
                string[] word = str.Split(" ");
                str = "";

                foreach (string str1 in word)
                {

                    if (!IgnoreList.Contains(str1))
                    {
                        str = str + (char.ToUpper(str1[0]) + str1.Substring(1)) + " ";
                    }
                    else
                    {
                        str = str + str1 + " ";

                    }
                }


                return str;



            }
        #endregion
    
        }
    
}
