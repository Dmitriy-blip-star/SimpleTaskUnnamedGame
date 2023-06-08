using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class Dwarf : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"I'm Dwarf and my speed is equal to {Speed}, my damage is equal to {Damage}");
        }
    }
}