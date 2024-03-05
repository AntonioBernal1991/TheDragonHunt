using UnityEngine;
namespace TheDragonHunt
{
    public class FireballSpawner : BaseSpawner
    {
        private void OnEnable()
        {
            MessageQueueManager.Instance.AddListener<
                FireballSpawnMessage>(OnFireballSpawned);
        }
        private void OnDisable()
        {
            MessageQueueManager.Instance.RemoveListener<
                FireballSpawnMessage>(OnFireballSpawned);
        }
        private void OnFireballSpawned(
            FireballSpawnMessage message)
        {
            GameObject fireball = SpawnObject();
            fireball.SetLayerMaskAllChildren("Unit");

            ProjectileComponent projectile =
                fireball.GetComponent<ProjectileComponent>();
            projectile.SetUp(message.position, message.rotation);
        }
    }
}


