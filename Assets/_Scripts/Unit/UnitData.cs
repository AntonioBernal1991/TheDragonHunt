using UnityEngine;
namespace TheDragonHunt
{

    [CreateAssetMenu(menuName = "TheDragonHunt/New Unit")]
    public class UnitData  : ScriptableObject
    {
        public UnitType Type;
        public Color    selectedColor;
        public int      level;
        public float    LevelMultiplier;
        public float    Health;
        public float    Attack;
        public float    Defense;
        public float    walkSpeed;
        public float    AttackSpeed;
        public ActionType Actions;
    }
}