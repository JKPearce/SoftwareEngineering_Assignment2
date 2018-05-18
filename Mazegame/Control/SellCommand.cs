using Mazegame.Entity;
using System;

namespace Mazegame.Control
{
    public class SellCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            String itemName = (String)userInput.Arguments[0];
            Item itemObject = thePlayer.PlayerInventory.GetItemObject(itemName);
            thePlayer.CurrentLocation.GetInventory().AddItem(itemObject);
            double itemPriceCalc = itemObject.GetValue() * 0.8;

            int itemPrice = Convert.ToInt32(itemPriceCalc);


            if (thePlayer.PlayerInventory.RemoveItem(itemName))
            {
                thePlayer.PlayerInventory.AddMoney(itemPrice);
                return new CommandResponse("Successfully sold " + itemName + " for " + itemPrice + " gold" + itemPriceCalc);
                
            }
            else
            {
                return new CommandResponse("You do not own a " + itemName);
            }
        }
    }
}
