using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IDamageable
    {
        void ApplyDamage(int damage);
    }
}