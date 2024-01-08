using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPrefabRepair : BaseShieldPrefab
{
    [SerializeField] private int _repairPrice = 1;
    [SerializeField] private int _scaleRepairPrice = 1;

    public void ShieldPrefabRepairing()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOff.gameObject.SetActive(false);
        this.shieldPrefab.DamageReceiver.ShowShieldSlider();
    }
    
    public void ShieldPrefabRepaired()
    {
        if (!this.shieldPrefab.DamageReceiver.IsCanRepair()) return;
        this.shieldPrefab.DamageReceiver.ShieldPrefabRepaired();
        ManagerCtrl.Instance.PlayerManager.PlayerCoin.DecreaseCoin(this._repairPrice);
        this._repairPrice += this._scaleRepairPrice;
        this._scaleRepairPrice++;
    }
    
}
