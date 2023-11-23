using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyChickenButton : LoboMonoBehaviour
{

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
        this.CheckPrice();
    }

    void CheckPrice()
    {
        int playerCoin = ManagerCtrl.Instance.PlayerManager.GetCoin();

        

    }    

}
