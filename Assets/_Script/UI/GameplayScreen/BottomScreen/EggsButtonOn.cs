using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsButtonOn : BaseButton
{
    [SerializeField] private bool isSpawnChicken = true;
    protected override void OnClick()
    {
        gameObject.SetActive(false);
        if(this.isSpawnChicken)
        {
            this.isSpawnChicken = false;
            this.SpawnChicken();
        }
        else
        {
            this.isSpawnChicken = true;
            this.SpawnShield();
        }
    }

    void SpawnChicken()
    {
        UICtrl.Instance.ChickenSpawner.ChickenSpawnInLobbyFromEgg();
    }

    void SpawnShield()
    {
        UICtrl.Instance.ShieldSpawner.ShieldSpawning();
    }

}
