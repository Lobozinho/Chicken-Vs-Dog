using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChickenPrefab : ObjectDragAndDrop
{
    [Header("Chicken")]
    [SerializeField] private ChickenShooting _chickenShooting;

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
