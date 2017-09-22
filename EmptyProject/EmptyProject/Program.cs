using System;
using System.Data;

namespace EmptyProject
{
        public static class Program
        {
            public static void Main(string[] args)
            {
                DataTable table1 = new DataTable("patients");
                table1.Columns.Add("name");
                table1.Columns.Add("id");
                table1.Rows.Add("james", 1);
                table1.Rows.Add("john", 2);

                DataTable table2 = new DataTable("patients2");
                table2.Columns.Add("id2");
                table2.Columns.Add("name2");
                table2.Rows.Add(1, "Lucy");
                table2.Rows.Add(2, "cathy");

                // Create a DataSet and put both tables in it.
                DataSet set = new DataSet("office");
                set.Tables.Add(table1);
                set.Tables.Add(table2);

                // Visualize DataSet.
                Console.WriteLine(set.GetXml());
            }
        }
}