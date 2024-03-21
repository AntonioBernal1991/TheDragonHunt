using System;
using UnityEngine;


namespace TheDragonHunt
{
    [Serializable]
    public class LevelItem 
    {
        public LevelItemType Type;
        public GameObject prefab;

        public LevelItemCollisionType collisionType;
    }


}

