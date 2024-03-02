using UnityEngine;
using System;
namespace TheDragonHunt

{
    [RequireComponent(typeof(BoxCollider), typeof(Animator))]
    public class UnitComponent : MonoBehaviour
    {
       
        public string ID;
        public UnitType Type;
        public int Level;
        public float LevelMultiplier;
        public float Health;
        public float Attack;
        public float Defense;
        public float WalkSpeed;
        public float AttackSpeed;
        public Color SelectedColor;
        private Animator _animator;
        private Renderer _renderer;

        private Vector3 _movePosition;
        private bool _shouldMove;

        private void Awake()
        {
            _renderer = GetComponentInChildren<Renderer>();
            _animator = GetComponent<Animator>();
            _animator.Play("Idle");
        }
        public void Update()
        {
            if(!_shouldMove)
            {
                return;
            }
            if(Vector3.Distance(transform.position, _movePosition) < 0.5f)
            {
                _animator.Play("Idle");
                _shouldMove = false;
                return;
            }

            Vector3 pos = (_movePosition - transform.position).normalized;
            transform.position += pos * Time.deltaTime*  WalkSpeed;
        }

        public void CopyData(UnitData unitData)
        {
            ID = Guid.NewGuid().ToString();
            Type = unitData.Type;
            LevelMultiplier = unitData.LevelMultiplier;
            Health = unitData.Health;
            Attack = unitData.Attack;
            Defense = unitData.Defense;
            WalkSpeed = unitData.walkSpeed;
            AttackSpeed = unitData.AttackSpeed;
            SelectedColor = unitData.selectedColor;
        }

        public void Selected(bool selected)
        {
            if(_renderer == null)
            {
                Debug.LogError("Renderer component is missing!");
                return;
            }
            Material[] materials = _renderer.materials;
            foreach(Material material in materials)
            {
                if(selected)
                {
                    material.EnableKeyword("_EMISSION");
                    material.SetColor("_EmissionColor", SelectedColor * 0.5f);
                }
              
                else
                {
                    material.DisableKeyword("_EMISSION");
                }

                

            }
        }
        public void MoveTo(Vector3 position)
        {
            transform.LookAt(position);

            _movePosition = position;
            _animator.Play("Run");
            _shouldMove = true;
        }
    }


}

