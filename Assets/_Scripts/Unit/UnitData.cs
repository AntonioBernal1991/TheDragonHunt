using UnityEngine;
namespace TheDragonHunt
{

    [CreateAssetMenu(menuName = "TheDragonHunt/New Unit")]
    public class UnitData  : BaseCharacterData
    {
        public UnitType Type;
        public int Level;
        public float LevelMultiplier;
        public ActionType Actions;
    }
}