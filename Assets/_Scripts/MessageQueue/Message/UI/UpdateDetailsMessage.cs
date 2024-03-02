
using System.Collections.Generic;
using UnityEngine;
namespace TheDragonHunt
{

    public class UpdateDetailsMessage : IMessage
    {
        public List<UnitComponent> units;
        public GameObject Model;
    }
   

}


