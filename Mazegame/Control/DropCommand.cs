using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace Mazegame.Control
{
    class DropCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput, Player thePlayer)
        {
            String itemName = (String) userInput.Arguments[0];
            Item itemObject = thePlayer.PlayerInventory.GetItemObject(itemName);
            thePlayer.CurrentLocation.GetInventory().AddItem(itemObject);
            return new CommandResponse(thePlayer.PlayerInventory.RemoveItem(itemName));
            //return new CommandResponse("test");
            //return new CommandResponse(thePlayer.PlayerInventory.RemoveItem(userInput.));
        }
    }
}
