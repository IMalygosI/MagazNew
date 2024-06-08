using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magaz
{
    internal class Type
    {
        private int _id;

        private string _type;

        public Type(int id, string type)
        {
            ID = id;
            TYPE = type;
        }
        //typeProduct
        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public string TYPE
        {
            get => _type;
            set => _type = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
