using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Background : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            GameObject clickedObject = EventSystem.current.currentSelectedGameObject;
            if (clickedObject == null)
            {
                Debug.Log("clickedObject null");
                this.DontUpgradeShield();
                return;
            }    
            Button clickedButton = clickedObject.GetComponent<Button>();
            if (clickedButton != null && clickedButton.gameObject.name == "ShieldUpGradeButtonOn") return;
        }
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
