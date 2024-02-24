using TMPro;
using UnityEngine;

namespace TheDragonHunt
{
    public class ResourcesUpdater : MonoBehaviour
    {
        [SerializeField] private ResourceType _type;
        [SerializeField] private TMP_Text _value;
        private int _currentValue;
        private void Awake()
        {
            if(_value == null)
            {
                Debug.LogError("Missing Tmp_text Variable in the script");
                return;
            }
            UpdateValue();



        }
        private void OnEnable()
        {
            MessageQueueManager.Instance
                .AddListener<UpdateResourceMessage>(
                OnResourceUpdated);
        }
       
        private void OnDisable()
        {
            MessageQueueManager.Instance
               .RemoveListener<UpdateResourceMessage>(
               OnResourceUpdated);
        }
        private void OnResourceUpdated(UpdateResourceMessage message)
        {
            if(_type == message.Type)
            {
                _currentValue += message.Amount;
                UpdateValue();
            }
        }
        private void UpdateValue()
        {
            _value.text = $"{_type}: {_currentValue}";
        }
    }
}

