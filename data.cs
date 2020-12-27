using System;
using System.IO;
using System.Collections.Generic;


namespace _2020_12_24_Black_Jack
{
    public static class data
    {
        public static List<card> read_data(string file)
        {
            List<card> cards = new List<card>();

            if(File.Exists(@file))
            {
                try
                {
                    StreamReader file_reader = new StreamReader(@file);

                    while (file_reader.Peek() >= 0)
                    {
                        cards.Add(parse(file_reader.ReadLine()));
                    }
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

            return cards;
        }

        public static card parse(string data_line)
        {
            string[] data_values = new string[5];
            string temp = data_line;

            for (int i = 0; i < data_values.Length; i++)
            {
                if (i != 4)
                {    
                    data_values[i] = temp.Substring(0, temp.IndexOf(","));
                    temp = temp.Substring(temp.IndexOf(",") + 1);
                }
                else
                {
                    data_values[i] = temp.Substring(0);
                }
            }

            return new card(data_values[0], data_values[1],Int32.Parse( data_values[2].Trim()), data_values[3].Trim(), data_values[4].Trim());
        }
    }
}