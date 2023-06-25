using System;
using System.Collections;
using System.Data;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Health : MonoBehaviour
    {
        [Header("Health stats")]
        [SerializeField] private int maxHealth;
        private int curentHealth;

        public event Action<int> HealthChange;

        private void Start()
        {
            curentHealth = maxHealth;
        }

        
    }
}