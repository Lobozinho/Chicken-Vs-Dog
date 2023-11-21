using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : Spawner
{
    [SerializeField] private Transform _parent;
    public void ChickenSpawnInLobby()
    {
        this._parent = this.GetParent();
        if (this._parent == null) return;
        Transform prefab = this.RandomPrefab();
        Vector3 spawnPos = transform.position;
        Transform obj = this.Spawn(prefab, spawnPos, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }

    protected override void SetParentNewPrefab(Transform newPrefab)
    {
        newPrefab.SetParent(this._parent, false);
    }

    Transform GetParent()
    {
        Transform parent = UICtrl.Instance.CheckLobbyEmpty();
        return parent;
    }

}
