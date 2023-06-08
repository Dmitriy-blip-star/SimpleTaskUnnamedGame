using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class Elf : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"<color=green> I'm Elf and my speed is equal to {Speed}, my damage is equal to {Damage} </color> ");
        }
    }
}