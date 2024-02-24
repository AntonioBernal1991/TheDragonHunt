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
    }





}

