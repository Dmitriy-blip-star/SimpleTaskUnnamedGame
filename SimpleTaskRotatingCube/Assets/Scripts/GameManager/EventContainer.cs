using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameManager
{
    public class EventContainer : MonoBehaviour
    {
        public static event Action EnemyDied;

        public static void OnEnemyDeid()
        {
            EnemyDied?.Invoke();
        }
    }
}