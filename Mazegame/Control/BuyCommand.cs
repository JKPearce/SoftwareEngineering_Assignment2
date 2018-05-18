using Mazegame.Entity;
using System;

namespace Mazegame.Control
{
    public class BuyCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            String itemName = (String)userInput.Arguments[0];
            Item itemObject = thePlayer.CurrentLocation.GetInventory().GetItemObject(itemName);
            int playersGold = thePlayer.PlayerInventory.GetTotalGold();
            int itemPrice = itemObject.GetValue();

            if (playersGold >= itemPrice)
            {
                thePlayer.CurrentLocation.GetInventory().RemoveItem(itemName);
                thePlayer.PlayerInventory.AddItem(itemObject);
                thePlayer.PlayerInventory.RemoveMoney(itemPrice);
                return new CommandResponse("Successfully purchased " + itemName);
            }
            else
            {
                return new CommandResponse("Not Enough gold, you only have " + playersGold + " gold.");
            }
            
        }
    }
}
