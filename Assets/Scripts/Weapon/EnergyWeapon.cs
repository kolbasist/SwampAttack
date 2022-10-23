using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnergyWeapon : Weapon
{
    [SerializeField] protected LaserBeam LaserBeam;
    [SerializeField] protected float MaxCharge;

    protected float ChargeValue;
    protected LaserBeam Projectile;

    public abstract void Shoot(Transform shootpoint, float charge);

    public abstract bool Charge( out float chargeValue);
}
