using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class UnitFactory : MonoBehaviour
    {
        [SerializeField] int minDamage = 10, maxDamage = 50;
        [SerializeField] int minSpeed = 1, maxSpeed = 5;

        [SerializeField] Transform spawnPoint;

        [SerializeField] int radiusSpawn;

        public void Create(Unit unit)
        {
            Unit instance = Instantiate(unit);
            instance.Initizalize(Random.Range(minDamage, maxDamage), Random.Range(minSpeed, maxSpeed));
            instance.SpawnTo(spawnPoint.position, radiusSpawn);
            instance.IssueCry();

        }
    }
}