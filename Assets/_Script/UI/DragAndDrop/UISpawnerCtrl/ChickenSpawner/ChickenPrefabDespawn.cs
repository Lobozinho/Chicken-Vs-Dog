using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenPrefabDespawn : MonoBehaviour
{

    public void Despawning()
    {
        transform.parent.SetParent(null, false);
        UICtrl.Instance.DragAndDrop.UISpawnerCtrl.ChickenSpawner.Despawn(transform.parent);
    }   

}
