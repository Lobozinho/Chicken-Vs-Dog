using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScreen : LoboMonoBehaviour
{
   
    [SerializeField] private BuyChickenButton _buyChickenButton;
    public BuyChickenButton BuyChickenButton => _buyChickenButton;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBuyChickenButton();
    }

    void LoadBuyChickenButton()
    {
        if (this._buyChickenButton != null) return;
        this._buyChickenButton = GetComponentInChildren<BuyChickenButton>();
        Debug.LogWarning(transform.name + ": LoadBuyChickenButton", gameObject);
    }

}
