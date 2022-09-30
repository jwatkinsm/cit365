using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JoshW
{
    public class DeskQuote
    {
        //variables
        public int BaseDeskPrice= 200;
        //get set values
        public Desk Desk;
        public int RushDays { get; set;}
        public string CustomerName { get ; set ; }
        public string QuoteDate { get; set; }
        //constructor
        public DeskQuote(string customerName, int rushDays, Desk desk)
        {
            CustomerName = customerName;
            RushDays = rushDays;
            Desk = desk;
            DateTime Today = DateTime.Today;
            QuoteDate = Today.ToString("dd MMMM yyyy");
        }
        //Rush order fee
        public int CalculateRushOrder(Desk desk)
        {
            int sizeOfDesk = desk.DeskSize();

            switch (RushDays)
            {
                case 3:
                    if(sizeOfDesk < 1000)
                    {
                        return 60;
                    }
                    else if(sizeOfDesk >= 1000 && sizeOfDesk <= 2000)
                    {
                        return 70;
                    }
                    else if(sizeOfDesk > 2000)
                    {
                        return 80;
                    }
                    break;

                case 5:
                    if (sizeOfDesk < 1000)
                    {
                        return 40;
                    }
                    else if (sizeOfDesk >= 1000 && sizeOfDesk <= 2000)
                    {
                        return 50;
                    }
                    else if (sizeOfDesk > 2000)
                    {
                        return 60;
                    }
                    break;

                case 7:
                    if (sizeOfDesk < 1000)
                    {
                        return 30;
                    }
                    else if (sizeOfDesk >= 1000 && sizeOfDesk <= 2000)
                    {
                        return 35;
                    }
                    else if (sizeOfDesk > 2000)
                    {
                        return 40;
                    }
                    break;
            }
            return 0;
        }   

        //drawer cost
        public int CalculateDrawerCost(Desk desk)
        {
            return desk.NumOfDrawers * 50;
        }
        //surface material cost
        public int SurfaceMaterialCost(Desk desk)
        {
            switch (desk.DeskMaterial)
            {
                case "oak":
                    return 200;
                    
                case "laminate":
                    return 100;
                    
                case "pine":
                    return 50;
                    
                case "rosewood":
                    return 300;
                    
                case "veneer":
                    return 125;
                   
            }
            return 0;
        }

        public int TotalPrice(Desk desk)
        {
            int rushOrderCost = CalculateRushOrder(desk);
            int materialCost = SurfaceMaterialCost(desk);
            int drawersTotal = CalculateDrawerCost(desk);
            int surfaceCost = desk.DeskSize();
            return rushOrderCost + materialCost + drawersTotal + surfaceCost + BaseDeskPrice;
        }
    }
}
