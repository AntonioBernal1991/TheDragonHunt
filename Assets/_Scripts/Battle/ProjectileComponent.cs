using UnityEngine;
namespace TheDragonHunt
{
    [RequireComponent(typeof(Rigidbody))]
    public class ProjectileComponent : MonoBehaviour
    {
        [SerializeField] private float _timeToLive;
        [SerializeField] private float _speed;
        private float _countdown;
        private Rigidbody _rigidbody;

        public float Damage;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            _countdown -= Time.deltaTime;
            if (_countdown <= 0)
            {
                gameObject.SetActive(false);
            }

        }
        public void SetUp(Vector3 position,Quaternion rotation,float damage)
        {
            transform.position = position;
            transform.rotation = rotation;
            Damage = damage;
            _countdown = _timeToLive;
            GetComponent<Rigidbody>().velocity =
                transform.rotation * Vector3.forward * _speed;
        }
    }

   

}

