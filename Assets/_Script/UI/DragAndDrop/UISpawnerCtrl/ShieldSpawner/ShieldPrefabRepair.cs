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
        this.ShowRepairPrice();
    }

    private void ShowRepairPrice()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOn.RepairPriceText.ShowRepairPrice(this._repairPrice);
    }
    
    public void ShieldPrefabRepaired()
    {
        if (!this.IsCanRepair()) return;
        this.shieldPrefab.DamageReceiver.ShieldPrefabRepaired();
        ManagerCtrl.Instance.PlayerManager.PlayerCoin.DecreaseCoin(this._repairPrice);
        this._repairPrice += this._scaleRepairPrice;
        this._scaleRepairPrice++;
    }

    private bool IsCanRepair()
    {
        if (!this.shieldPrefab.DamageReceiver.IsCanRepair()) return false;
            
        return true;
    }

    private bool CheckMoney()
    {
        int playerCoin = ManagerCtrl.Instance.PlayerManager.PlayerCoin.Coin;
        if (playerCoin < this._repairPrice)
        {
            this.CantRepair();
            return false;
        }
        return true;
    }
    
    private void CantRepair()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldRepair.ButtonOff.gameObject.SetActive(true);
    }
    
}
