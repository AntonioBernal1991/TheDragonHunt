using UnityEditor;
namespace TheDragonHunt
{
    public static class unitDebugger
    {
        [MenuItem("TheDragonHunt/Debug/Unit/Spawn Warrior %g")]
      
        private static void SpawnWarrior()
        {
            MessageQueueManager.Instance.SendMessage(
                new BasicWarriorSpawnMessage());
        }
        [MenuItem("TheDragonHunt/Debug/Unit/Spawn Mage %h")]
        private static void SpawnMage()
        {
            MessageQueueManager.Instance.SendMessage(
                new BasicMageSpawnMessage());
        }
    }





}

