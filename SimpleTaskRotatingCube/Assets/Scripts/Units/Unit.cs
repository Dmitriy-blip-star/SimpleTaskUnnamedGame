using Assets.Scripts.GameManager;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public abstract class Unit : MonoBehaviour, IDamageable
    {
        protected int Damage;
        protected int Speed;
        protected int Health;

        //private void Start()
        //{
        //    EventContainer.EnemyDied += Dead;
        //}

        //private void OnDestroy()
        //{
        //    EventContainer.EnemyDied -= Dead;
        //}

        public void Initizalize(int damage, int speed)
        {
            Damage = damage;
            Speed = speed;
        }
        public void SpawnTo(Vector3 spawnPoint, int radiusSpawn)
        {
            Vector2 randomPoint = Random.insideUnitCircle * radiusSpawn;
            transform.position = spawnPoint + new Vector3(randomPoint.x, 0, randomPoint.y);
        }
        //public abstract void Dead();
        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}