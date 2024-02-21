
using System.Collections.Generic;
using UnityEngine;
namespace TheDragonHunt
{
    public class ObjectPoolComponent : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private int _poolSize;
        [SerializeField] private bool _allowcreation;
        [SerializeField] private List<GameObject> _gameObjects;

        private void Awake()
        {
            for (int i = 0; i < _poolSize;i++)
            {
                _gameObjects.Add(CreateItem(false));
            }
        }

        private GameObject CreateItem(bool Active)
        {
            GameObject item = Instantiate(_prefab);
            item.transform.SetParent(transform);
            item.SetActive(Active);
            return item;
        }

        public GameObject GetObject()
        {
            foreach(GameObject item in _gameObjects)
            {
                if(!item.activeInHierarchy)
                {
                    item.SetActive(true);
                    return item;
                }
            }
            if(_allowcreation)
            {
                GameObject item = CreateItem(true);
                _gameObjects.Add(item);
                return item;
            }
            return null;
        }
    }
}

