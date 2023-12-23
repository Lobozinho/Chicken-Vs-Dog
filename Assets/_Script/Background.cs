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
                //this.SetFalseIsSelectedAllShieldPrefab();
                //this.DisableShieldUpgradeButton();
                return;
            }    
            Button clickedButton = clickedObject.GetComponent<Button>();
            if (clickedButton != null)
            {
                Debug.Log("Clicked on a UI Button!");
            }
            else
            {
                Debug.Log("Clicked on a UI Element, but not a Button.");
            }
        }    
        //this.SetFalseIsSelectedAllShieldPrefab();
        //this.DisableShieldUpgradeButton();
    }

    bool CheckIsclickShieldUpgradeButton()
    {
        ShieldUpGradeButtonOn buttonOn = this.GetShieldUpGradeButton();
        bool isClick = buttonOn.IsClick;
        if (isClick) return true;
        return false;
    }

    ShieldUpGradeButtonOn GetShieldUpGradeButton()
    {
        return UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.ButtonOn;
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
