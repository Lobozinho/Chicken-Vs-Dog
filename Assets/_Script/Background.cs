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
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.DontUpgradeShield();
    }

}
