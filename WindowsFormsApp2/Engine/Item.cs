﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item : ICloneable
    {
     //   public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        //public int LevelRequired { get; set; }
        public int Number { get; set; }
        public bool IsUsable;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Item(int number = 0)
        {
            Number = number;
            IsUsable = false;
        }
        public Item()
        {
            Number = 0;
            IsUsable = false;
        }

        public class CraftableItem : Item
        {
            public List<Item> ItemsNeededForCraft = new List<Item>();
            public CraftableItem(int number)
                : base(number)
            {
                
            }
                
        }

        public class Shovel : CraftableItem
        {
            public Shovel(int number)
                : base(number)
            {
                Name = "Łopata";
                NamePlural = "Łopaty";
                Item.Wood Wood = new Item.Wood(3);
                Item.Stone Stone = new Item.Stone(2);
                ItemsNeededForCraft.Add(Wood);
                ItemsNeededForCraft.Add(Stone);
            }
        }

        public class Bucket : CraftableItem
        {
            public bool hasWater
            {
                get { return _hasWater;  }
                set
                {
                    _hasWater = value;
                    if (_hasWater)
                    {
                        Name = "Wiadro z wodą";
                        NamePlural = "Wiadra z wodą";
                    }
                }
            }
            private bool _hasWater;
            public Bucket(int number)
                : base(number)
            {
                Name = "Wiadro";
                NamePlural = "Wiadra";
                Item.Wood Wood = new Item.Wood(4);
                ItemsNeededForCraft.Add(Wood);
                _hasWater = false;
            }
        }

        public class FishingRod : CraftableItem
        {
            public FishingRod(int number)
                :base(number)
            {
                Name = "Wędka";
                NamePlural = "Wędki";
                Item.Wood Wood = new Item.Wood(2);
                ItemsNeededForCraft.Add(Wood);
            }
        }

        public class Wood : Item
        {
            public Wood(int number)
                : base(number)
            {
                NamePlural = Name = "Drzewno";
            }
        }

        public class Stone : Item
        {
            public Stone(int number)
                : base(number)
            {
                Name = "Kamień";
                NamePlural = "Kamienie";
            }
        }

        public class Food : Item
        {
            public int Energy; 
            public Food(int number)
                : base(number)
            {
                IsUsable = true;
            }
        }
        public class MushroomEdible : Food
        {
            public MushroomEdible(int number)
                : base(number)
            {
                Energy = 10;
                Name = "Grzyb";
                NamePlural = "Grzyby";
            }
        }

        public class MushroomNotEdible : Food
        {
            public MushroomNotEdible(int number)
                : base(number)
            {
                Energy = -195;
                Name = "Trując. grz.";
                NamePlural = "Trując. grz.";
            }
        }

        public class Corn : Food
        {
            public Corn(int number)
                : base(number)
            {
                Name = NamePlural = "Kukurydza";
            }
        }

        public class Carrot : Food
        {
            public Carrot(int number)
                : base(number)
            {
                Name = NamePlural = "Marchew";
            }
        }

        public class Turnip : Food
        {
            public Turnip(int number)
                : base(number)
            {
                Name = NamePlural = "Rzepa";
            }
        }

        public class Beet : Food
        {
            public Beet(int number)
                : base(number)
            {
                Name = "Burak";
                NamePlural = "Buraki";
            }
        }

        public class Apple : Food
        {
            public Apple(int number)
                : base(number)
            {
                Name = "Jabłko";
                NamePlural = "Jabłka";
            }
        }


        public class Wheat : Food
        {
            public Wheat(int number)
                : base(number)
            {
                Name = NamePlural = "Pszenica";
            }
        }

        public class Cabbage : Food
        {
            public Cabbage(int number)
                : base(number)
            {
                Name = "Kapusta";
                NamePlural = "Kapusty";
            }
        }

        public class Cucumber : Food
        {
            public Cucumber(int number)
                : base(number)
            {
                Name = "Ogórek";
                NamePlural = "Ogórki";
            }
        }

        public class Tomato : Food
        {
            public Tomato(int number)
                : base(number)
            {
                Name = "Pomidor";
                NamePlural = "Pomidory";
            }
        }

        public class Eggplant : Food
        {
            public Eggplant(int number)
                : base(number)
            {
                Name = "Bakłażan";
                NamePlural = "Bakłażany";
            }
        }

        public class Watermelon : Food
        {
            public Watermelon(int number)
                : base(number)
            {
                Name = "Arbuz";
                NamePlural = "Arbuzy";
            }
        }

        public class Pear : Food
        {
            public Pear(int number)
                : base(number)
            {
                Name = "Gruszka";
                NamePlural = "Gruszki";
            }
        }

        public class Cherry : Food
        {
            public Cherry(int number)
                : base(number)
            {
                Name = "Wiśnia";
                NamePlural = "Wiśnie";
            }
        }

        public class Pumpkin : Food
        {
            public Pumpkin(int number)
                : base(number)
            {
                Name = "Dynia";
                NamePlural = "Dynie";
            }
        }

        public class Peach : Food
        {
            public Peach(int number)
                : base(number)
            {
                Name = "Brzoskwinia";
                NamePlural = "Brzoskwinie";
            }
        }

        public class Fish : Food
        {
            public Fish(int number)
                : base(number)
            {
                Name = "Ryba";
                NamePlural = "Ryby";
            }
        }

        public class Seed : Food
        {
            public int id;
            public int id2;
            public Seed(int number)
                : base(number)
            {
                id = id2 = 0;
                Energy = 1;
            }
        }
        
        public class WheatSeed : Seed
        {
            public WheatSeed(int number)
                : base(number)
            {
                id = 2;
                id2 = 1;
                Name = "Ziarno pszenicy";
                NamePlural = "Ziarna pszenicy";
            }
        }

        public class CornSeed : Seed
        {
            public CornSeed(int number)
                : base(number)
            {
                Name = "Ziarno kukurydzy";
                NamePlural = "Ziarna kukurydzy";
                Energy = 2;
            }
        }

        public class CarrotSeed : Seed
        {
            public CarrotSeed(int number)
                : base(number)
            {
                id = 1;
                id2 = 1;
                Name = "Nasienie marchwi";
                NamePlural = "Nasiona marchwi";
            }
        }

        public class TurnipSeed : Seed
        {
            public TurnipSeed(int number)
                : base(number)
            {
                id = 1;
                id2 = 2;
                Name = "Nasienie rzepy";
                NamePlural = "Nasiona rzepy";
            }
        }

        public class BeetSeed : Seed
        {
            public BeetSeed(int number)
                : base(number)
            {
                id = 1;
                id2 = 3;
                Name = "Nasienie buraka";
                NamePlural = "Nasiona buraka";
            }
        }

        public class CucumberSeed : Seed
        {
            public CucumberSeed(int number)
                : base(number)
            {
                Name = "Nasienie ogórka";
                NamePlural = "Nasiona ogórka";
            }
        }

        public class PumpkinSeed : Seed
        {
            public PumpkinSeed(int number)
                : base(number)
            {
                Name = "Nasienie dyni";
                NamePlural = "Nasiona dyni";
                Energy = 2;
            }
        }

        public class AppleSeed : Seed
        {
            public AppleSeed(int number)
                : base(number)
            {
                Name = "Nasienie jabłka";
                NamePlural = "Nasiona jabłka";
            }
        }

        public class CabbageSeed : Seed
        {
            public CabbageSeed(int number)
                : base(number)
            {
                id = 3;
                id2 = 2;
                Name = "Nasienie kapusty";
                NamePlural = "Nasiona kapusty";
            }
        }


        public class Potato : Seed
        {
            public Potato(int number)
                : base(number)
            {
                Energy = 10;
                id = 3;
                id2 = 1;
                Name = "Ziemniak";
                NamePlural = "Ziemniaki";
            }
        }
    }

}
