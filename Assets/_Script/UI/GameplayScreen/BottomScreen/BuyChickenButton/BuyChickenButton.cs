using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BuyChickenButton : LoboMonoBehaviour
{
    [Header("Components")]
    [SerializeField] private BuyChickenButtonOff _buttonOff;
    [SerializeField] private BuyChickenButtonOn _buttonOn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBuyChickenButtonOff();
        this.LoadBuyChickenButtonOn();
    }

    void LoadBuyChickenButtonOff()
    {
        if (this._buttonOff != null) return;
        this._buttonOff = GetComponentInChildren<BuyChickenButtonOff>();
        Debug.LogWarning(transform.name + ": LoadBuyChickenButtonOff", gameObject);
    }

    void LoadBuyChickenButtonOn()
    {
        if (this._buttonOn != null) return;
        this._buttonOn = GetComponentInChildren<BuyChickenButtonOn>();
        Debug.LogWarning(transform.name + ": LoadBuyChickenButtonOn", gameObject);
    }

    protected override void Awake()
    {
        this.ShowChickenPriceText();
        this.CheckPrice();
    }

    void ShowChickenPriceText()
    {
        int chickenPrice = this._buttonOn.chickenPrice;
        this._buttonOn.ChickenPriceText.ShowChickenPriceText(chickenPrice);
    }    

    public void CheckPrice()
    {
        int playerCoin = ManagerCtrl.Instance.PlayerManager.GetCoin();
        int chickenPrice = this._buttonOn.chickenPrice;
        if (chickenPrice <= playerCoin) return;
        this._buttonOn.gameObject.SetActive(false);
        this._buttonOff.ChickenPriceText.ShowChickenPriceText(chickenPrice);
    }    

}
