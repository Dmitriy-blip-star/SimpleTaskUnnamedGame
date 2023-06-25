using Assets.Scripts.GameManager;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Presenter : MonoBehaviour
    {
        [SerializeField] Text score;
        [SerializeField] Text listCount;

        [SerializeField] Image healthBarFilling;

        private void Start()
        {
            EventContainer.EnemyDied += EnemysCountChanged;
            EventContainer.HealthChange += OnHelthFactoryChanged;
        }

        private void OnHelthFactoryChanged(float valueAsPercantage)
        {
            healthBarFilling.fillAmount = valueAsPercantage;
        }

        private void Update()
        {
            
            listCount.text = EnemySpawner.enemys.Count.ToString();
        }

        public void ScoreChanged(int curentScore)
        {
            score.text = $"Score is: {curentScore}";
        }

        void EnemysCountChanged()
        {
            
        }
    }
}