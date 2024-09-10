using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class Menu
    {
        public int id;
        public string title;
        public int parentID;

        public Menu(int ID, string Title, int ParentID)
        {
            id = ID;
            title = Title;
            parentID = ParentID;
        }
    }
}
