using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPrefabRepair : BaseShieldPrefab
{
    
    public void ShieldPrefabRepairing()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOn.gameObject.SetActive(true);
        this.ShowShieldSlider();
    }
    
    private void ShowShieldSlider()
    {
        int hpMax = this.shieldPrefab.DamageReceiver.HPMax;
        int hp = this.shieldPrefab.DamageReceiver.HP;
        float newValue = hp / hpMax;
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOn.ShieldSlider.ShowShieldSlider(newValue);
    }

}
