using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPrefabRepair : BaseShieldPrefab
{
    
    public void ShieldPrefabRepairing()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOn.gameObject.SetActive(true);
        this.shieldPrefab.DamageReceiver.ShowShieldSlider();
    }
    
    public void ShieldPrefabRepaired()
    {
        this.shieldPrefab.DamageReceiver.ShieldPrefabRepaired();
    }    

}
