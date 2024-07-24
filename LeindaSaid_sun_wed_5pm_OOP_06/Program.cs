using System.Diagnostics.Tracing;
using static LeindaSaid_sun_wed_5pm_OOP_06.Book;

namespace LeindaSaid_sun_wed_5pm_OOP_06

{
    public delegate string GetATitleDelegate(Book book);
    public delegate decimal GetAPriceDelegate(Book book);
    public delegate string GetISBN(Book book);
    public delegate DateTime GetPublicationDate(Book book);
    public delegate Array GetAuthors(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ques_1
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(0, "Leindaaa");
            //bool ARepeated = false;
            //string Nonrepeatingletters = "";

            //for (int i = 0; i < dictionary.Count; i++)
            //{
            //    for (int j = 0; j < dictionary.Values.Count; j++)
            //    {
            //        //Console.WriteLine(dictionary.Values.ElementAt(j));
            //        string name = dictionary.Values.ElementAt(j);
            //        for (int k = 0; k < name.Length; k++)
            //        {
            //            for (int l = k + 1; l < name.Length; l++)
            //            {
            //                if (name[k] == name[l])
            //                {
            //                    ARepeated = true;
            //                    break;

            //                }
            //            }

            //            if (ARepeated == false)
            //            {
            //                Nonrepeatingletters = name[k].ToString();
            //                Console.WriteLine(Nonrepeatingletters);
            //                //ARepeated = true;
            //            }
            //        }
            //    }
            //}
            #endregion

            #region Ques_2
            GetATitleDelegate Get_Title_Delegate = BookFunctions.GetAsTitle;
            GetAPriceDelegate Get_Price_Delegate = BookFunctions.GetPrice;
            GetISBN Get_ISBN_Delegate = BookFunctions.GetISBN;
            GetPublicationDate Get_PubDate_Delegate = BookFunctions.GetPublicationDate;
            GetAuthors Get_Authors_Delegate = BookFunctions.GetAuthors;
            
            #endregion
        }
    }
}

