using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerGunController : MonoBehaviour, IGunControllable
{
    [SerializeField] Gun gun;

    public void SwitchGun(Gun gun)
    {
        this.gun = gun;
    }

    public void Shoot()
    {
        this.gun.Shoot();
    }
}
