using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : ObjectDragAndDrop
{

    [SerializeField] private ShieldModel _shieldModel;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldModel();
    }

    void LoadShieldModel()
    {
        if (this._shieldModel != null) return;
        this._shieldModel = GetComponentInChildren<ShieldModel>();
        Debug.LogWarning(transform.name + ": LoadShieldModel", gameObject);
    }

    private void OnEnable()
    {
        string parentName = transform.parent.name;
        if (parentName.Substring(0, Math.Min(5, parentName.Length)) != "Lobby") return;
        this._shieldModel.gameObject.transform.localPosition = new Vector3(0, 10, 0); 
    }

}
