using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace Mazegame.Control
{
    class PickUpCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput, Player thePlayer)
        {
            String itemName = (String)userInput.Arguments[0];
            Item itemObject = thePlayer.CurrentLocation.GetInventory().GetItemObject(itemName);
            thePlayer.CurrentLocation.GetInventory().RemoveItem(itemName);
            thePlayer.PlayerInventory.AddItem(itemObject);
            return new CommandResponse("Picked up " + itemName);
        }
    }
}
