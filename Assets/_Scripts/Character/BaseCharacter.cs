using System;
using System.Collections;
using UnityEngine;

namespace TheDragonHunt
{
    public class BaseCharacter : MonoBehaviour
    {
        protected Animator _animator;
        protected Renderer _renderer;
        protected Color _originalColor;
        protected Color _emissionColor;
        protected ActionType _action;

        public string ID;
        public float Health;
        public float Attack;
        public float Defense;
        public float WalkSpeed;
        public float AttackSpeed;
        public Color SelectedColor;
        public float AttackRange;
        public float ColliderSize;

        public bool IsDead { get; private set; }

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _animator = GetComponent<Animator>();
            _originalColor = _renderer.material.color;
            _emissionColor =
                _renderer.material.GetColor("_EmissionColor");
        }
        private void OnMouseEnter()
        {
            _renderer.material.color = SelectedColor;
        }
        private void OnMouseExit()
        {
            _renderer.material.color = _originalColor;
        }

        protected void CopyBaseData(BaseCharacterData data)
        {
            ID = Guid.NewGuid().ToString();
            Health = data.Health;
            Attack = data.Attack;
            Defense = data.Defense;
            WalkSpeed = data.WalkSpeed;
            AttackSpeed = data.AttackSpeed;
            SelectedColor = data.SelectedColor;
            AttackRange = data.AttackRange;
            ColliderSize = data.ColliderSize;
        }
        protected virtual void UpdateState(ActionType action)
        {
            if(IsDead || _action == action)
            {
                return;
            }
            _action = action;
        }
        protected virtual void PlayAnimation(UnitAnimationState state)
        {
            throw new NotImplementedException();
        }

        public bool TakeDamage(float damage)
        {
            if(IsDead)
            {
                return true;
            }

            Health -= damage;
            if(Health > 0)
            {
                return false;
            }
            gameObject.AddComponent<DeadComponent>();
            PlayAnimation(UnitAnimationState.Death);
            IsDead = true;
            return true;
        }
        public Vector3 GetDamageFeedBackPosition()
        {
            return new Vector3(
                transform.position.x + _renderer.bounds.size.x / 2,
                transform.position.y + _renderer.bounds.size.y / 2,
                transform.position.z);
                
        }


    }
}

