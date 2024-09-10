using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class MenuData
    {
        public List<Menu> menus = new List<Menu>()
        {
            new Menu(1,KeyDic.nameSport,0),
            new Menu(2,KeyDic.nameScoial,0),
            new Menu(3,KeyDic.nameSportCountry,1),
            new Menu(4,KeyDic.nameTraffic,2),
            new Menu(5,KeyDic.nameEnviroment,2),
            new Menu(6,KeyDic.nameSportNationnal,1),
            new Menu(7,KeyDic.nameEvirCity,5),
            new Menu(8,KeyDic.nameBadTraffic,4)
        };

        public void printMenu(List<Menu> menu)
        {
            menu = new List<Menu>();
            for (int i = 0; i < menu.Count; i++)
            {
                if (menus[i].id == menus[i].parentID)
                {
                    
                }
            }
        }

    }
}
