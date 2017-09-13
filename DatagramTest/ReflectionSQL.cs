using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DatagramTest
{
    public class GenericEntity<T>
    {
        private T obj;

        public GenericEntity(T obj)
        {
            this.obj = obj;
        }
        public string InsertString()
        {
            StringBuilder insertValues = new StringBuilder();
            StringBuilder columnNames = new StringBuilder();

            Type type = typeof(T);
            PropertyInfo[] propInfo = type.GetProperties();

            foreach (PropertyInfo property in propInfo)
            {
                if (columnNames.ToString() == string.Empty)
                    columnNames.AppendFormat("INSERT INTO {0} ({1}",
                       type.Name, property.Name);
                else
                {
                    columnNames.AppendFormat(", {0}", property.Name);
                    insertValues.Append(",");
                }
                insertValues.Append("{" + '@' + property.Name + "}");
                Console.WriteLine(property.GetValue(obj));
            }

            if (columnNames.ToString() != string.Empty)
                columnNames.AppendFormat(") VALUES({0})", insertValues.ToString());

            return columnNames.ToString();
        }
    }
}

