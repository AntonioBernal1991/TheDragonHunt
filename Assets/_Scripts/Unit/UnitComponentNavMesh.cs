using UnityEngine;
using UnityEngine.AI;

namespace TheDragonHunt
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitComponentNavMesh : UnitComponent
    {
        private NavMeshAgent _agent;
        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }
        protected override void UpdatePosition()
        {
            _agent.destination = GetFinalposition();
        }
        protected override void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
            if(!collision.gameObject.CompareTag("Plane"))
            {
                _agent.isStopped = true;
            }
        }


    }
}

