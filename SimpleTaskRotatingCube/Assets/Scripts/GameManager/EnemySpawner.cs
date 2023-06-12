using Assets.Scripts.Units;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GameManager
{
    
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] UnitFactory unitFactory;

        public List<Unit> enemys = new List<Unit>();

        [SerializeField] int limitUnitsOnMap = 10;

        private void Start()
        {
            
        }

        private void Update()
        {
            if (enemys.Count <= limitUnitsOnMap)
            {
                enemys.Add(unitFactory.Create());
            }
        }
    }
}