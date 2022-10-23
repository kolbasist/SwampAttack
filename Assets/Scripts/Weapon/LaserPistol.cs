using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPistol : EnergyWeapon
{    
    public override void Shoot(Transform shootPoint)
    {
        ChargeValue = 0f;
        Projectile = Instantiate(LaserBeam, shootPoint.position, Quaternion.identity);
        Projectile.gameObject.SetActive(false);
    }

    public override void Shoot(Transform shootpoint,float charge)
    {        
        Projectile.SetCharge(charge);
        Projectile.gameObject.SetActive(true);
    }

    public override bool Charge(out float chargeValue)
    {
        bool isCharging = (Input.GetMouseButton(0) && ChargeValue <= MaxCharge);

        if (isCharging)
        {
            ChargeValue += Time.deltaTime;
        }
                
        chargeValue = ChargeValue;
        return isCharging;        
    }    
}
