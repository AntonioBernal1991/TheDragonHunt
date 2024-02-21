using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TheDragonHunt
{
    [CreateAssetMenu(menuName = "TheDragonHunt/New Configuration")]
    public class LevelConfiguration : ScriptableObject
    {
        public List<LevelItem> LevelItems = new List<LevelItem>();

        public LevelItem FindByType(LevelItemType type)
        {
            return LevelItems.Find(item => item.Type == type);
        }




    }



}


