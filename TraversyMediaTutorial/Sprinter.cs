//Namespace
using System;
using System.Collections.Generic;

namespace TraversyMediaTutorial
{
    class Sprinter
    {
        
        private int index;

        public List<string> Sponsors = new List<string>();
        public ConsoleColor color;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Race
        {
            get { return new String('#', Position); }
        }
        public string SponsorsStr
        {
            get { return " <"+String.Join(" , ", Sponsors); }
        }


    }
}
