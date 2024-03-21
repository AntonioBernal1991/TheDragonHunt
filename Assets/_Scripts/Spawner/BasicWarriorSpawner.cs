using System;
using UnityEngine;
namespace TheDragonHunt
{
    public class BasicWarriorSpawner : BaseSpawner
    {
        [SerializeField] public UnitData _unitData;
        private void OnEnable()
        {
            MessageQueueManager.Instance
                .AddListener<BasicWarriorSpawnMessage>(
                OnBasicWarriorSpawned);
        }
        private void OnDisable()
        {
            MessageQueueManager.Instance
                .RemoveListener<BasicWarriorSpawnMessage>(
                OnBasicWarriorSpawned);
        }
        private void OnBasicWarriorSpawned(BasicWarriorSpawnMessage message)
        {
            GameObject warrior = SpawnObject();
            warrior.SetLayerMaskAllChildren("Unit");
            UnitComponentNavMesh unit =
                warrior.GetComponent<UnitComponentNavMesh>();

            if (unit == null)
            {
                unit = warrior.AddComponent<UnitComponentNavMesh>();
            }
            unit.CopyData(_unitData);
  
           

        }

       
    }
}
