using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : LoboMonoBehaviour
{

    [SerializeField] private SpawnerCtrl _spawnerCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnerCtrl();
    }

    void LoadSpawnerCtrl()
    {
        if (this._spawnerCtrl != null) return;
        this._spawnerCtrl = FindAnyObjectByType<SpawnerCtrl>();
        Debug.LogWarning(transform.name + ": LoadSpawnerCtrl", gameObject);
    }

    public void BulletSpawning(Vector3 spawnPos)
    {
        this._spawnerCtrl.BulletSpawner.Spawning(spawnPos);
    }

}
