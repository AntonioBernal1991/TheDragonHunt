namespace TheDragonHunt
{
    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            MessageQueueManager.Instance.SendMessage(
                new ActionCommandMessage
                {
                    Action =
                ActionType.Move
                });
        }
           
    }
}


