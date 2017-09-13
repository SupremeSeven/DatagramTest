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
        public string Insert()
        {
            StringBuilder sb = new StringBuilder();
            int ctr = 0;

            Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();


            PropertyInfo[] propInfo = type.GetProperties();
            foreach (PropertyInfo pi in propInfo)
            {
                if (sbQry.ToString() == string.Empty)
                    sbQry.AppendFormat("INSERT INTO {0} ({1}",
                       type.Name.Replace("Entity", string.Empty), pi.Name);
                else
                {
                    sbQry.AppendFormat(", {0}", pi.Name);
                    sb.Append(",");
                }
                sb.Append("{" + ctr++ + "}");
                Console.WriteLine(pi.GetValue(obj));
            }

            if (sbQry.ToString() != string.Empty)
                sbQry.AppendFormat(") VALUES({0})", sb.ToString());

            return sbQry.ToString();
        }
    }
}

