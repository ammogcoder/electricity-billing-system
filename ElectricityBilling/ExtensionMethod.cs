using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBilling
{
    public static class ExtensionMethod
    {
        public static DataTable AsDataTable<T>(this IEnumerable<T> list)
     where T : class
        {
            DataTable dtOutput = new DataTable("tblOutput");

            //if the list is empty, return empty data table
            if (list.Count() == 0)
                return dtOutput;

            //get the list of  public properties and add them as columns to the
            //output table           
            PropertyInfo[] properties = list.FirstOrDefault().GetType().
                GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo propertyInfo in properties)
                dtOutput.Columns.Add(propertyInfo.Name, propertyInfo.PropertyType);

            //populate rows
            DataRow dr;
            //iterate through all the objects in the list and add them
            //as rows to the table
            foreach (T t in list)
            {
                dr = dtOutput.NewRow();
                //iterate through all the properties of the current object
                //and set their values to data row
                foreach (PropertyInfo propertyInfo in properties)
                {
                    dr[propertyInfo.Name] = propertyInfo.GetValue(t, null);
                }
                dtOutput.Rows.Add(dr);
            }
            return dtOutput;
        }
    }
}
