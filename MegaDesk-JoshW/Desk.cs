using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_JoshW
{
    enum DeskMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }
    public class Desk
    {
        //variables
        public string DeskMaterial;
        //get set value
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }
        //constants
        const int MaxWidth = 94;
        const int MinWidth = 24;
        const int MaxDepth = 48;
        const int MinDepth = 12; 

        //constructor
        public Desk(int width, int depth, int numOfDrawers, string deskMaterial)
        {
            Width = width;
            Depth = depth;
            NumOfDrawers = numOfDrawers;
            DeskMaterial = deskMaterial;
        }
        public int DeskSize()
        {
            return Width * Depth;
        }
        
    }
}
