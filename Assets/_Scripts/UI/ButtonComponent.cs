
using UnityEngine;

namespace TheDragonHunt
{
    public class ButtonComponent : MonoBehaviour
    {
        public ActionType Action;
        private ICommand _command;

        private void Start()
        {
            switch (Action)
            {
                case ActionType.Attack:
                    _command = new AttackCommand();
                    break;
                case ActionType.Defense:
                    _command = new AttackCommand();
                    break;
                case ActionType.Move:
                    _command = new AttackCommand();
                    break;
                case ActionType.Collect:
                    _command = new AttackCommand();
                    break;
                case ActionType.Build:
                case ActionType.Upgrade:
                case ActionType.None:
                default:
                    break;
            }
        }
    }

}
