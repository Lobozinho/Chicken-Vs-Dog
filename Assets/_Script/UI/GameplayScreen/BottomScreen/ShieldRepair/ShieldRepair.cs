using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldRepair : LoboMonoBehaviour
{

    [SerializeField] private ShieldRepairButtonOn _buttonOn;
    public ShieldRepairButtonOn ButtonOn => _buttonOn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldRepairButtonOn();
    }

    void LoadShieldRepairButtonOn()
    {
        if (this._buttonOn != null) return;
        this._buttonOn = GetComponentInChildren<ShieldRepairButtonOn>();
        Debug.LogWarning(transform.name + ": LoadShieldRepairButtonOn", gameObject);
    }


}
