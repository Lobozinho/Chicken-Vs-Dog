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
        Debug.Log("DontUpgradeShield");
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.DontUpgradeShield();
    }

}
