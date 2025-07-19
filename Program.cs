using System.Text;
using PointsBet_Backend_Online_Code_Test;

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {

        //Before
        public static string ToCommaSepatatedList(string[] items, string quote)

        {
            StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

            if (items.Length > 1)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                }
            }
            return qry.ToString();
        }


        //After 
        public static string ToCommaSepatatedList2(string[] items, string quote)
        {
            int LENGTH = items.Length;
            string[] arr = new string[LENGTH];

            for (int i = 0; i < LENGTH; i++)
            {
                arr[i] = string.Format("{0}{1}{0}", quote, items[i]);
            }

            return string.Join(",", arr);
        }
        

    }
}

