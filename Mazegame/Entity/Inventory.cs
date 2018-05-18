using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Entity
{
    public class Inventory
    {
        private Money gold;
        private Dictionary<string, Item> itemList;

        public Inventory()
        {
            gold = new Money();
            itemList = new Dictionary<string, Item>();
        }

        public void AddMoney(int goldPieces)
        {
            gold.Add(goldPieces);
        }

        public bool RemoveMoney(int goldPieces)
        {
            return gold.Subtract(goldPieces);
        }

        public int GetTotalGold()
        {
            return gold.Total;
        }

        public void AddItem(Item theItem)
        {
            itemList[theItem.GetLabel()] = theItem;
        }

        public bool RemoveItem(string itemName)
        {
            if (!itemList.ContainsKey(itemName))
                return false;
            itemList.Remove(itemName);
            return true;
        }

        public Item GetItemObject(string itemName)
        {
            if(itemList.ContainsKey(itemName))
                return itemList[itemName];
            throw new ItemNotFoundException("That item does not exist.");
        }


        private string printItemList()
        {
            if (itemList.Count == 0)
                return "No items here";
            StringBuilder returnMsg = new StringBuilder();
            returnMsg.Append("Items here ::");
            foreach (string item in itemList.Keys)
            {
                returnMsg.Append(" [" + item + "]");
            }
            return returnMsg.ToString();
        }

        public override string ToString()
        {
            return printItemList() + "\n" + gold.ToString();
        }
    }

    public class ItemNotFoundException : Exception
    {
        private string message;

        public ItemNotFoundException()
            : base()
        {
        }

        public ItemNotFoundException(string message)
        {
            this.message = message;
        }

        public string GetMessage()
        {
            return this.message;
        }
    }
}
