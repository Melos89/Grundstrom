using System;
using System.Collections.Generic;
using System.Text;
using Grundstrom.Pages;
using Grundstrom.Pages.PersonalPages;

namespace Grundstrom.Resources
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Ordertelefon",
                TargetType = typeof(OrderTelephonePage)
            });

            this.Add(new MenuItem()
            {
                Title = "Produktionschef",
                TargetType = typeof(HakanFrankPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Logistikchef",
                TargetType = typeof(StefanAkessonPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Produktchef",
                TargetType = typeof(JonasRasmussonPage)
            });
            this.Add(new MenuItem()
            {
                Title = "VD",
                TargetType = typeof(PeterGrundstromPage)
            });
            this.Add(new MenuItem()
            {
                Title = "Maknadschef",
                TargetType = typeof(StefanSchillPage)
            });
        }
    }
}
