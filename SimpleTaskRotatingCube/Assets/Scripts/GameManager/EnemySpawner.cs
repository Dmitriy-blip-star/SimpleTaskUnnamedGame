using Assets.Scripts.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GameManager
{
    
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] UnitFactory unitFactory;

        List<Unit> enemys = new List<Unit>();

        [SerializeField] int delay = 1;

        private void Start()
        {
            
        }

        private void Update()
        {
            StartCoroutine(CreateEnemy());
            //if (enemys.Count < 10)
            //{
            //    StartCoroutine(CreateEnemy());
            //}

        }

        IEnumerator CreateEnemy()
        {
            yield return new WaitForSeconds(delay);
            enemys.Add(unitFactory.Create());
        }

        //public void UnitDead()
        //{
        //    enemys.RemoveAt(0);
        //}
    }
}