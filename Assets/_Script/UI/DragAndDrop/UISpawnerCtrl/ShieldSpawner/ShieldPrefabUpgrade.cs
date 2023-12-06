using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPrefabUpgrade : MonoBehaviour
{
    [SerializeField] private int _upgradePrice = 1;
    
    public void ShieldPrefabUpgrading()
    {
        ShieldUpgrade shieldUpgrade = UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade;
        shieldUpgrade.ButtonOn.gameObject.SetActive(true);
        shieldUpgrade.PriceText.ShowUpGradePrice(this._upgradePrice);
    }

}
