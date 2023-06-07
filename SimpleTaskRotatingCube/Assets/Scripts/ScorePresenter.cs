using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScorePresenter : MonoBehaviour
    {
        [SerializeField] Player player;
        [SerializeField] Text score;

        public void ScoreChanged(int curentScore)
        {
            score.text = $"Score is: {curentScore}";
        }
    }
}