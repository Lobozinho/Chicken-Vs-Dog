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

    public void ShieldPrefabRepaired()
    {
        this.Reborn();
        this.ShowShieldSlider();
    }

    public void ShowShieldSlider()
    {
        float newValue = (float)this.hp / (float)this.hpMax;
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOn.ShieldSlider.ShowShieldSlider(newValue);
    }

    public bool IsCanRepair()
    {
        if (this.hp == this.hpMax) return false;
        return true;
    }

}
