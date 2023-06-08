using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class Elf : Unit
    {
        public override void IssueCry()
        {
            Debug.Log("Elf!");
        }
    }
}