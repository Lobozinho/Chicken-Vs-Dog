using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Background : MonoBehaviour, IPointerClickHandler
{

    public void OnPointerClick(PointerEventData eventData)
    {
        this.DontUpgradeShield();
    }

    private void DontUpgradeShield()
    {
        this.SetFalseIsSelectedAllShieldPrefab();
        this.OnEnableShieldUpgradeButtonOff();
    }    

    private void SetFalseIsSelectedAllShieldPrefab()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            shield.SetFalseIsSelected();
        }
    }    

    private void OnEnableShieldUpgradeButtonOff()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.ButtonOff.gameObject.SetActive(true);
    }

    
}
