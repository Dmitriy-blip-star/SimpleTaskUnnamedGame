using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public abstract class Unit : MonoBehaviour
    {
        protected int Damage;
        protected int Speed;

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
    }
}