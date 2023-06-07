using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Shotgun : Gun
    {
        public override void Shoot()
        {
            if (curentTimeReload <= 0)
            {
                for (int i = -1; i < 1; i++)
                {
                    Bullet bullet = Instantiate(this.bullet, bulletSpawnPoint.position + Vector3.right * i, transform.rotation);
                }
                curentTimeReload = timeReload;
            }
        }
    }
}