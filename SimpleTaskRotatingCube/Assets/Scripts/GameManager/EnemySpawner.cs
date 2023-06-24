using Assets.Scripts.Units;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GameManager
{
    
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] UnitFactory unitFactory;

        public static List<Unit> enemys = new List<Unit>();
        int index;

        [SerializeField] int limitUnitsOnMap = 10;
        [SerializeField] float delay;

        private void Start()
        {
            StartCoroutine(EnemySpawn());
            EventContainer.EnemyDied += EnemyReturnFromList;
        }

        IEnumerator EnemySpawn()
        {
            while (true)
            {
                enemys.Add(unitFactory.Create());
                delay -= 0.1f;
                if (delay <= 0.5f)
                {
                    delay = 0.5f;
                }
                yield return new WaitForSeconds(delay);
            }
        }

        public void EnemyReturnFromList()
        {
            
            enemys.RemoveAt(index);
            index++;
        }
        void TestReturnFromList(GameObject gm)
        {

        }


    }
}