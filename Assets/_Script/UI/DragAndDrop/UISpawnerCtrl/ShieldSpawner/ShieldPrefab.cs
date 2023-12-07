using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShieldPrefab : ObjectDragAndDrop
{
    [Header("Shield Prefab")]
    [SerializeField] private ShieldModel _shieldModel;
    [SerializeField] private ShieldPrefabUpgrade _upgrade;
    public ShieldPrefabUpgrade Upgrade => _upgrade;

    [SerializeField] private ShieldDamageReceiver _damageReceiver;
    public ShieldDamageReceiver DamageReceiver => _damageReceiver;

    [SerializeField] private bool _isDrag = false;
    [SerializeField] private bool _isSelected = false;
    public bool IsSelected => _isSelected;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShieldModel();
        this.LoadShieldPrefabUpgrade();
        this.LoadShieldDamageReceiver();
    }

    void LoadShieldModel()
    {
        if (this._shieldModel != null) return;
        this._shieldModel = GetComponentInChildren<ShieldModel>();
        Debug.LogWarning(transform.name + ": LoadShieldModel", gameObject);
    }

    void LoadShieldPrefabUpgrade()
    {
        if (this._upgrade != null) return;
        this._upgrade = GetComponentInChildren<ShieldPrefabUpgrade>();
        Debug.LogWarning(transform.name + ": LoadShieldPrefabUpgrade", gameObject);
    }

    void LoadShieldDamageReceiver()
    {
        if (this._damageReceiver != null) return;
        this._damageReceiver = GetComponentInChildren<ShieldDamageReceiver>();
        Debug.LogWarning(transform.name + ": LoadShieldDamageReceiver", gameObject);
    }

    private void OnEnable()
    {
        this._isDrag = false;
        string parentName = transform.parent.name;
        if (parentName.Substring(0, Math.Min(5, parentName.Length)) != "Lobby") return;
        this._shieldModel.gameObject.transform.localPosition = new Vector3(0, 10, 0); 
    }

    public override void OnDrag(PointerEventData eventData)
    {
        if (this._isDrag) return;
        base.OnDrag(eventData);
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        if (this._isDrag) return;
        base.OnBeginDrag(eventData);
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        if (this._isDrag) return;
        base.OnEndDrag(eventData);
        this.CheckShieldPlacement();
    }

    void CheckShieldPlacement()
    {
        string parentName = transform.parent.name;
        if (parentName.Substring(0, Math.Min(6, parentName.Length)) != "Shield") return;
        this._isDrag = true;
    }

    private void OnMouseDown()
    {
        this._upgrade.ShieldPrefabUpgrading();
        this.SetFalseIsSelectedAllShieldPrefab();
        this._isSelected = true;
    }

    void SetFalseIsSelectedAllShieldPrefab()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach(ShieldPrefab shield in allShields)
        {
            shield.SetFalseIsSelected();   
        }   
    }
    
    public void SetFalseIsSelected()
    {
        this._isSelected = false;
    }

}
