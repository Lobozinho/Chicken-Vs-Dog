using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDamageReceiver : DamageReceiver
{

    [SerializeField] private int _scaleHP = 1;
    
    public void UpgradeHp()
    {
        this.hpMax += this._scaleHP;
        this.Reborn();
        this._scaleHP += 1;
    }

}
