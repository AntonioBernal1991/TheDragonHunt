using UnityEngine;
using UnityEditor;

namespace TheDragonHunt
{
    public static class EnemyDebbuger
    {
        [MenuItem("TheDragonHunt/Debug/Enemy/Spawn Orc")]
        private static void SpawnOrc()
        {
            MessageQueueManager.Instance.SendMessage(
                new BasicOrcSpawnMessage()
                {
                    SpawnPoint = new Vector3(-6, 0, 0)
                });
        }

        [MenuItem("TheDragonHunt/Debug/Enemy/Spawn Golem")]
        private static void SpawnGolem()
        {
            MessageQueueManager.Instance.SendMessage(
                new BasicGolemSpawnMessage()
                {
                    SpawnPoint = new Vector3(6, 0, 0)
                });
        }

        [MenuItem("TheDragonHunt/Debug/Enemy/Spawn Red Dragon")]
        private static void SpawnRedDragon()
        {
            MessageQueueManager.Instance.SendMessage(
                new RedDragonSpawnMessage()
                {
                    SpawnPoint = new Vector3(0, 0, 6)
                });
        }
    }
}

