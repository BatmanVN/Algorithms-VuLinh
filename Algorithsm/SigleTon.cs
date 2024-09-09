using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class SigleTon<T> where T : class,new()
    {
        private static T _instance;
        protected SigleTon() { }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
    }
}
