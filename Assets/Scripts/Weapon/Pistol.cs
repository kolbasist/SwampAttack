using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Firearm
{
    public override void Shoot(Transform shootpoint)
    {
        if(Time.timeScale != 0)
        Instantiate(Bullet, shootpoint.position, Quaternion.identity);
    }
}
