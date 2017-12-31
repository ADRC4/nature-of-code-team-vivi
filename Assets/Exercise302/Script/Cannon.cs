using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform muzzle;
    public Projetile projectile;
    public float betweenShoots = 100;
    public float muzzleVelocity = 35;

    float nextShootTime;

    public void Shoot()
    {
        if (Time.time > nextShootTime)
        {
            nextShootTime = Time.time + betweenShoots / 1000;
        }

        Projetile newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projetile;
        //newProjectile.SetSpeed(muzzleVelocity);
    }


}
