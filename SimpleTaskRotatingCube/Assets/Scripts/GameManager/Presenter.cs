using Assets.Scripts.GameManager;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Presenter : MonoBehaviour
    {
        [SerializeField] Text score;
        [SerializeField] Text listCount;

        private void Start()
        {
            EventContainer.EnemyDied += EnemysCountChanged;
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