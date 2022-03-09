using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace InventoryManagement
{
    class Program
    {   
        static void Main(string[] args)
        {

            InventoryManager manager = new InventoryManager();
            string file = @"C:\Users\ankit\Desktop\bridgelab\.Net\Inventory Management\InventoryManage\InventoryManage\json.json";
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    manager.DisplayInventory(utility.RiceList);
                    break;
                case 2:
                    manager.DisplayInventory(utility.WheatList);
                    break;
                case 3:
                    manager.DisplayInventory(utility.PulseList);
                    break;
            }
        }
    }
    class InventoryUtility
    {
        public List<Rice> RiceList { get; set; }
        public List<Wheat> WheatList { get; set; }
        public List<Pulse> PulseList { get; set; }



        public class Pulse
        {
            public string Name
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }
        }

        public class Wheat
        {
            public string Name
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }
        }

        public class Rice
        {
            public string Name
            {
                get;
                set;
            }
            public int Price
            {
                get;
                set;
            }
            public int Kg
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }
        }

    }
    class InventoryManager
    {
        public void DisplayInventory(List<InventoryUtility.Rice> ricelist)
        {
            foreach (InventoryUtility.Rice i in ricelist)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }

        }
        public void DisplayInventory(List<InventoryUtility.Wheat> wheatList)
        {
            foreach (InventoryUtility.Wheat i in wheatList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulseList)
        {
            foreach (InventoryUtility.Pulse i in pulseList)
            {
                Console.WriteLine("Name: {0} \nKg: {1} \nPrice: {2} \nType:{3}\n", i.Name, i.Kg, i.Price, i.Type);
            }
        }
    }
}


