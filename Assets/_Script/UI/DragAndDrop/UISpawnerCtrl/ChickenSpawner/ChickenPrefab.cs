using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChickenPrefab : ObjectDragAndDrop
{
    [Header("Chicken")]
    [SerializeField] const string STANDY = "Standy";
    [SerializeField] private ChickenShooting _chickenShooting;
    public ChickenShooting ChickenShooting => _chickenShooting;

    protected override void CheckIsCanDrag()
    {
        string parentName = transform.parent.name;
        if (parentName.Substring(0, Math.Min(6, parentName.Length)) != STANDY) return;
        this.isCanDrag = false;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadChickenShooting();
    }

    void LoadChickenShooting()
    {
        if (this._chickenShooting != null) return;
        this._chickenShooting = GetComponentInChildren<ChickenShooting>();
        Debug.LogWarning(transform.name + ": LoadChickenShooting", gameObject);
    }

}
