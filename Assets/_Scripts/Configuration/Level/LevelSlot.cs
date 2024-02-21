using System;
using UnityEngine;

namespace TheDragonHunt

{
    [Serializable]
    public class LevelSlot
    {
        public LevelItemType itemType;
        public Vector2Int Coordinates;
        
        public LevelSlot(LevelItemType type,Vector2Int coordinates)
        {
            itemType = type;
            Coordinates = coordinates;
        }

    }




}
