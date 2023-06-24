using Assets.Scripts.GameManager;
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

        [SerializeField] Unit[] units;

        public Unit Create()
        {
            Unit instance = Instantiate(units[Random.Range(0, units.Length)]);
            instance.Initizalize(Random.Range(minDamage, maxDamage), Random.Range(minSpeed, maxSpeed));
            instance.SpawnTo(spawnPoint.position, radiusSpawn);
            //instance.IssueCry();
            return instance;
        }


    }
}