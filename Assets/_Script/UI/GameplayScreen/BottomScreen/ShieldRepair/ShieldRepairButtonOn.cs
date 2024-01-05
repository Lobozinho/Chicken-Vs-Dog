using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRepairButtonOn : BaseButton
{
    [SerializeField] private ShieldSlider _shieldSlider;
    public ShieldSlider ShieldSlider => _shieldSlider;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldSlider();
    }

    void LoadShieldSlider()
    {
        if (this._shieldSlider != null) return;
        this._shieldSlider = GetComponentInChildren<ShieldSlider>();
        Debug.LogWarning(transform.name + ": LoadShieldSlider", gameObject);
    }


    protected override void OnClick()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            if (!shield.IsSelected) continue;
            shield.Repair.ShieldPrefabRepaired();
        }
    }

}
