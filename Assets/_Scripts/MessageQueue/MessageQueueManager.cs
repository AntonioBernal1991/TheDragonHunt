using System;
using System.Collections.Generic;
namespace TheDragonHunt
{
    public class MessageQueueManager 
    {
        private readonly Dictionary<Type,
            List<Delegate>> _listeners;
        private static MessageQueueManager _instance;
        public static MessageQueueManager Instance
        {
            get
            {
                return _instance ?? (_instance =
                    new MessageQueueManager());
            }
        }
        private MessageQueueManager()
        {
            _listeners = new Dictionary<Type, List<Delegate>>();
        }
    }
}


