﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int LevelRequired { get; set; }

        public Item(int id, string name, string namePlural, int levelRequired = 0)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            LevelRequired = levelRequired;
        }
    }

}