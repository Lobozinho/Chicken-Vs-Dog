using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUpGradeButtonOff : LoboMonoBehaviour
{

    [SerializeField] private ShieldUpGradePriceText _upGradePriceText;
    public ShieldUpGradePriceText UpGradePriceText => _upGradePriceText;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldUpGradePriceText();
    }

    void LoadShieldUpGradePriceText()
    {
        if (this._upGradePriceText != null) return;
        this._upGradePriceText = GetComponentInChildren<ShieldUpGradePriceText>();
        Debug.LogWarning(transform.name + ": LoadShieldUpGradePriceText", gameObject);
    }

}
