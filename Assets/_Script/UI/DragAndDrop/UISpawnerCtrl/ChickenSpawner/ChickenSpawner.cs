using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : Spawner
{

    void ChickenSpawning()
    {
        Transform prefab = this.RandomPrefab();
        Vector3 spawnPos = transform.position;
        Transform obj = this.Spawn(prefab, spawnPos, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    protected override void SetParentNewPrefab(Transform newPrefab)
    {
        newPrefab.SetParent(this.holder, false);
    }

    public void SpawnInLobby()
    {
        this.ChickenSpawning();
    }

}
