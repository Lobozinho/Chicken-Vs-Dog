using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawnerCtrl : LoboMonoBehaviour
{

    [SerializeField] private ChickenSpawner _chickenSpawner;
    public ChickenSpawner ChickenSpawner => _chickenSpawner;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadChickenSpawner();
    }

    void LoadChickenSpawner()
    {
        if (this._chickenSpawner != null) return;
        this._chickenSpawner = GetComponentInChildren<ChickenSpawner>();
        Debug.LogWarning(transform.name + ": LoadChickenSpawner", gameObject);
    }

}
