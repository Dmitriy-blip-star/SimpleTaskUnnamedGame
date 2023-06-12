using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class TestEnemy : MonoBehaviour, IDamageable
    {

        [SerializeField] int maxHealth;
        int curentHealth;

        private void Start()
        {
            curentHealth = maxHealth;
        }

        public void ApplyDamage(int damage)
        {
            curentHealth -= damage;
            Debug.Log($"Enemy has: {curentHealth}HP");

            if (curentHealth <= 0)
            {
                Debug.Log($"Enemy is dead");
                Destroy(gameObject); 
            }
        }
    }
}