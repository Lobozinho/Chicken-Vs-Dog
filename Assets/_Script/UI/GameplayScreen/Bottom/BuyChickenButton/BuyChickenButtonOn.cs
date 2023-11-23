using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyChickenButtonOn : BaseButton
{

    [SerializeField] private ChickenPriceText _chickenPriceText;
    public ChickenPriceText ChickenPriceText => _chickenPriceText;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadChickenPriceText();
    }

    void LoadChickenPriceText()
    {
        if (this._chickenPriceText != null) return;
        this._chickenPriceText = GetComponentInChildren<ChickenPriceText>();
        Debug.LogWarning(transform.name + ": LoadChickenPriceText", gameObject);
    }

    protected override void OnClick()
    {
        UICtrl.Instance.ChickenSpawnInLobby();
    }

}
