using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : LoboMonoBehaviour
{

    [SerializeField] private List<Transform> _spawnPositions;
    public List<Transform> SpawnPositions => _spawnPositions;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPositions();
    }

    void LoadSpawnPositions()
    {
        if (this._spawnPositions.Count > 0) return;

        foreach (Transform spawnPos in transform)
        {
            this._spawnPositions.Add(spawnPos);
        }

        Debug.Log(transform.name + ": LoadSpawnPositions", gameObject);
    }

    public Transform RamdomSpawnPosition()
    {
        int index = Random.Range(0, this._spawnPositions.Count);
        return this._spawnPositions[index];
    }

}
