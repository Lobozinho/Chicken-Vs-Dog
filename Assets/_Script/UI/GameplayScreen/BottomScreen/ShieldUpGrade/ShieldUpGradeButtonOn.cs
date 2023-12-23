using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShieldUpGradeButtonOn : BaseButton
{

    [Header("Shield UpGrade Button On")]
    [SerializeField] private ShieldUpGradePriceText _upGradePriceText;
    public ShieldUpGradePriceText UpGradePriceText => _upGradePriceText;

    [SerializeField] private bool _isClick;
    public bool IsClick => _isClick;

    public void SetIsClick(bool isClick)
    {
        this._isClick = isClick;
    }

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

    protected override void OnClick()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            if (!shield.IsSelected) continue;
            shield.Upgrade.ShieldUpgraded();
        }
        this._isClick = true;
    }

    

}
