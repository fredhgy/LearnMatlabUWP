using System.Collections.Generic;

namespace Learn_Matlab_UWP.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public Menu()
        {
            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem("\uE1CE", "首页", typeof(StartView)));
            MenuItems.Add(new MenuItem("\uE1CE", "第一章", typeof(Ch1View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第二章", typeof(Ch2View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第三章", typeof(Ch3View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第四章", typeof(Ch4View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第五章", typeof(Ch5View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第六章", typeof(Ch6View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第七章", typeof(Ch7View)));
            MenuItems.Add(new MenuItem("\uE1CE", "第八章", typeof(Ch8View)));
            MenuItems.Add(new MenuItem("\uE1CE", "关于", typeof(AboutView)));
            MenuItems.Add(new MenuItem("\uE1CE", "版本号：1.0.0", typeof(ImportView)));
        }
    }
}