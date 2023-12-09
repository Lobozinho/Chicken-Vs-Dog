using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyChickenButtonOn : BaseButton
{

    protected override void OnClick()
    {
        UICtrl.Instance.DragAndDrop.UISpawnerCtrl.ChickenSpawner.ChickenZeroSpawnInLobby();
        int chickenPrice = this.GetChickenPrice();
        ManagerCtrl.Instance.PlayerManager.PlayerCoin.DecreaseCoin(chickenPrice);
        UICtrl.Instance.CheckAllPriceInUI();
    }

    int GetChickenPrice()
    {
        BottomScreen bottomScreen = UICtrl.Instance.GameplayScreen.BottomScreen;
        int chickenPrice = bottomScreen.BuyChickenButton.ChickenPriceText.ChickenPrice;
        return chickenPrice;
    }    

}
