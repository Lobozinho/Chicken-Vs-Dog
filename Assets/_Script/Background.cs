using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    private void OnMouseDown()
    {
        this.SetFalseIsSelectedAllShieldPrefab();
        this.DisableShieldUpgradeButton();
    }

    void SetFalseIsSelectedAllShieldPrefab()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            shield.SetFalseIsSelected();
        }
    }    

    void DisableShieldUpgradeButton()
    {
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.ButtonOn.gameObject.SetActive(false);
    }

}
