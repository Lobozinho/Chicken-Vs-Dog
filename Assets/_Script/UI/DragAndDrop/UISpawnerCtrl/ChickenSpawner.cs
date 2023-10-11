using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : Spawner
{

    private void FixedUpdate()
    {
        this.ChickenSpawning();
    }

    void ChickenSpawning()
    {
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, transform.position, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    protected override void SetParentNewPrefab(Transform newPrefab)
    {
        newPrefab.SetParent(this.holder, false);
    }

}
