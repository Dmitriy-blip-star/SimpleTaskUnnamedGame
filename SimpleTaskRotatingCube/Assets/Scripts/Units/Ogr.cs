using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Units
{
    public class Ogr : Unit
    {
        public override void IssueCry()
        {
            Debug.Log($"<color=red> I'm Ogr and my speed is equal to {Speed}, my damage is equal to {Damage} </color> ");
        }
    }
}