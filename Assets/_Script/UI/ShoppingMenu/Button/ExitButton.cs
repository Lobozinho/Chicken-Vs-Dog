using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : BaseButton
{
    
    protected override void OnClick()
    {
        UICtrl.Instance.ShoppingMenu.gameObject.SetActive(false);
        UICtrl.Instance.GameplayScreen.gameObject.SetActive(true);
    }

}
