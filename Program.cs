using System;

namespace Day15_HashTable
{
    class Program
    {
        private static object hash;
     public static void Main(string[] args)
      { 

            //Console.WriteLine("**********Welcome Hash Table**********");
                #region UC1
                //UC1_MyMapNode<string, string> hash = new UC1_MyMapNode<string, string>(5);
                //hash.Add("0", "To");
                //hash.Add("1", "be");
                //hash.Add("2", "or");
                //hash.Add("3", "not");
                //hash.Add("4", "to");
                //hash.Add("5", "be");
                //string hash5 = hash.Get("5");
                //Console.WriteLine("5th index value " + hash5);
                //string hash2 = hash.Get("5");
                //Console.WriteLine("2nd index value " + hash2);
                #endregion

                #region UC2
                //UC2_MyMapNode<string, int> Hash = new UC2_MyMapNode<string, int>(20);
                //string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                //string[] word = sentence.ToLower().Split(" ");
                //int keys = 0;
                //int k = keys++;
                //string key = k.ToString();
                //Console.WriteLine(wc);
                //int key = Hash.Get(wc);
                //if (key == 0)
                //key = 1;
            //else
            {
                //key = key + 1;
                //Hash.Add(wc, key);
            }
            //int value = Hash.Get("paranoid");
            //Console.WriteLine(value);
            //Console.WriteLine("Hash code is " + value);
            //Console.ReadLine();
            #endregion

            #region UC3
            //UC3_MyMapNode<string, string> Hash1 = new UC3_MyMapNode<string, string>(20);
            string sentence1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence1.ToLower().Split(" ");
            int key11 = 0;
            //foreach (string wc in words)
            {
                int k = key11++;
                string key1 = k.ToString();
                //Console.WriteLine(wc);
                //int key = Hash.Get(wc);
                //if (key == 0)
                //    key = 1;
                //else
                //    key = key + 1;
                //Hash1.Add(key1, wc);
            }
            //string value1 = Hash1.Get("Paranoids");
            //Console.WriteLine(value);
            //Console.WriteLine("Hash code of {0} is{1}", value1, value1.GetHashCode());
            // Hash1.GetArrayPosition(value1);
            //Hash1.Remove("avoidable");
            #endregion
        }
    }
}