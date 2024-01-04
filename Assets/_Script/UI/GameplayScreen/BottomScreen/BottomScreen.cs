using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomScreen : LoboMonoBehaviour
{
   
    [SerializeField] private BuyChickenButton _buyChickenButton;
    public BuyChickenButton BuyChickenButton => _buyChickenButton;

    [SerializeField] private ShieldUpgrade _shieldUpgrade;
    public ShieldUpgrade ShieldUpgrade => _shieldUpgrade;

    [SerializeField] private ShieldRepair _shieldRepair;
    public ShieldRepair ShieldRepair => _shieldRepair;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadBuyChickenButton();
        this.LoadShieldUpgrade();
        this.LoadShieldRepair();
    }

    void LoadBuyChickenButton()
    {
        if (this._buyChickenButton != null) return;
        this._buyChickenButton = GetComponentInChildren<BuyChickenButton>();
        Debug.LogWarning(transform.name + ": LoadBuyChickenButton", gameObject);
    }

    void LoadShieldUpgrade()
    {
        if (this._shieldUpgrade != null) return;
        this._shieldUpgrade = GetComponentInChildren<ShieldUpgrade>();
        Debug.LogWarning(transform.name + ": LoadShieldUpgrade", gameObject);
    }

    void LoadShieldRepair()
    {
        if (this._shieldRepair != null) return;
        this._shieldRepair = GetComponentInChildren<ShieldRepair>();
        Debug.LogWarning(transform.name + ": LoadShieldRepair", gameObject);
    }

}
