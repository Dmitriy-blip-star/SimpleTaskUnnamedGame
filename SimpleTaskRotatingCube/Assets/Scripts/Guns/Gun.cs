using Assets.Scripts;
using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected Bullet bullet;
    [SerializeField] protected Transform bulletSpawnPoint;

    [SerializeField] protected float timeReload;
    protected float curentTimeReload;

    public virtual void Shoot()
    {
        if (curentTimeReload <= 0)
        {
            Bullet bullet = Instantiate(this.bullet, bulletSpawnPoint.position, transform.rotation);
            bullet.Initialize();
            curentTimeReload = timeReload;
        }
    }

    void Update()
    {
        if (curentTimeReload > 0)
        {
            curentTimeReload -= Time.deltaTime;
        }
    }
}
