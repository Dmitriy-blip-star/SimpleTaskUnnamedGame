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

        public void Initizalize(int damage, int speed)
        {
            Damage= damage;
            Speed= speed;
        }

        public void SpawnTo(Vector3 spawnPoint, int radiusSpawn)
        {
            Vector2 randomPoint = Random.insideUnitCircle * radiusSpawn;
            transform.position = spawnPoint + new Vector3(randomPoint.x, 0, randomPoint.y);
        }


        public abstract void IssueCry();

        public void ApplyDamage(int damage)
        {
            Health -= damage;
        }
    }
}