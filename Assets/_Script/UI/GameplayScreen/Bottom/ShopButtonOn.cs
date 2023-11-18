using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonOn : BaseButton
{
    protected override void OnClick()
    {
        UICtrl.Instance.OnEnableShoppingMenu();
        UICtrl.Instance.DisableGameplayScreen();
    }
}
