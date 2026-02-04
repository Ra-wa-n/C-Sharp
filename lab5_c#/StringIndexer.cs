using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_c_
{
    internal class StringIndexer
    {
        string[] coll1;
        Dictionary<string,string> col2 = new Dictionary<string,string>();
        public StringIndexer(int size)
            
        {
            coll1= new string[size];
        }

        public string this[int index]
        {
            get
            {
                return coll1[index];
            }
            set
            {
                coll1[index] = value;
            }
        }
        public string this[string key] 
        {
            get
            {
                return col2[key];
            }
            set
            {
                col2[key] = value;
            }
        }

      
        
    }
}