using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : LoboMonoBehaviour
{

    [SerializeField] private List<Transform> _spawnPositions;
    public List<Transform> SpawnPositions => _spawnPositions;

    [SerializeField] private List<List<Transform>> _spawnTransforms;

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

    public Vector3 RamdomSpawnPosition()
    {
        int index = Random.Range(0, this._spawnPositions.Count);
        Transform spawnPoint = this._spawnPositions[index];
        Vector3 spawnPos = spawnPoint.position;
        return spawnPos;
    }

    public void AddDogToList()
    {
        
    }   

}
