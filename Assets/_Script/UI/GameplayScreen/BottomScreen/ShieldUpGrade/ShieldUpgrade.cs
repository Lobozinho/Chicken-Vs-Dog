using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUpgrade : LoboMonoBehaviour
{

    [SerializeField] private ShieldUpGradeButtonOn _buttonOn;
    public ShieldUpGradeButtonOn ButtonOn => _buttonOn;

    [SerializeField] private ShieldUpGradePriceText _priceText;
    public ShieldUpGradePriceText PriceText => _priceText;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldUpGradeButtonOn();
        this.LoadUpGradePriceText();
    }

    void LoadShieldUpGradeButtonOn()
    {
        if (this._buttonOn != null) return;
        this._buttonOn = GetComponentInChildren<ShieldUpGradeButtonOn>();
        Debug.LogWarning(transform.name + ": LoadShieldUpGradeButtonOn", gameObject);
    }

    void LoadUpGradePriceText()
    {
        if (this._priceText != null) return;
        this._priceText = GetComponentInChildren<ShieldUpGradePriceText>();
        Debug.LogWarning(transform.name + ": LoadUpGradePriceText", gameObject);
    }

}
