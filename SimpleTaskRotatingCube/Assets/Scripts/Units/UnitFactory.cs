using Assets.Scripts.GameManager;
using System;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class UnitFactory : MonoBehaviour, IDamageable
    {
        [Header("Health stats")]
        [SerializeField] private int maxHealth;
        private int curentHealth;

        [SerializeField] int minDamage = 10, maxDamage = 50;
        [SerializeField] int minSpeed = 1, maxSpeed = 5;

        [SerializeField] Transform spawnPoint;

        [SerializeField] int radiusSpawn;

        [SerializeField] Unit[] units;

        private void Start()
        {
            curentHealth = maxHealth;
        }

        public void ApplyDamage(int damage)
        {
            curentHealth -= damage;
            if (curentHealth <= 0)
            {
                Death();
            }
            else
            {
                float curentHPAsPercantage = (float)curentHealth / maxHealth;
                EventContainer.OnHeathFactotyChanged(curentHPAsPercantage);
            }
        }

        private void Death()
        {
            Destroy(gameObject);
        }

        public Unit Create()
        {
            Unit instance = Instantiate(units[UnityEngine.Random.Range(0, units.Length)]);
            instance.Initizalize(UnityEngine.Random.Range(minDamage, maxDamage), UnityEngine.Random.Range(minSpeed, maxSpeed));
            instance.SpawnTo(spawnPoint.position, radiusSpawn);
            //instance.IssueCry();
            return instance;
        }




    }
}