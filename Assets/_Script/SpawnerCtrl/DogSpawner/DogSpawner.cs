using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawner : Spawner
{
    [Header("Dog Spawner")]
    [SerializeField] private SpawnPosition _spawnPosition;

    [SerializeField] private float _timer;
    [SerializeField] private float _timeDelay = 5f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPosition();
    }

    protected virtual void LoadSpawnPosition()
    {
        if (this._spawnPosition != null) return;
        this._spawnPosition = GetComponentInChildren<SpawnPosition>();
        Debug.LogWarning(transform.name + ": LoadSpawnPosition", gameObject);
    }

    private void FixedUpdate()
    {
        this.Spawning();
    }

    void Spawning()
    {
        if (this.CheckTimeDelay()) return;
        Transform prefab = this.RandomPrefab();
        Vector3 spawnPos = this._spawnPosition.RamdomSpawnPosition().position;
        Transform obj = this.Spawn(prefab, spawnPos, Quaternion.identity);
        obj.gameObject.SetActive(true);
    }
    
    bool CheckTimeDelay()
    {
        if(this._timer < this._timeDelay)
        {
            this._timer += Time.fixedDeltaTime;
            return true;
        }
        this._timer = 0;
        return false;
    }

}
