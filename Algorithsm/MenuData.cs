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
        
        public Dictionary<int,List<Menu>> listMenus = new Dictionary<int,List<Menu>>();
        
        public void printMenu(List<Menu> menu)
        {
            //menu = new List<Menu>();
            //for (int i = 0; i < menus.Count; i++)
            //{
            //    if (menus[0].id == menus[i].parentID)
            //    {
            //        listMenus.Add(menus[0].id,menu);
            //    }
            //}
        }

    }
}
