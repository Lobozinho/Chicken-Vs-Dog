using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenShooting : MonoBehaviour
{
    
    [SerializeField] protected bool isShooting = false;

    [SerializeField] protected float shootDelay = 1f;
    [SerializeField] protected float shootTimer = 0f;

    private void FixedUpdate()
    {
        this.Shooting();
    }

    void Shooting()
    {
        if (!this.isShooting) return;
        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;
        ManagerCtrl.Instance.SpawnerManager.BulletSpawning(transform.parent.position);
    }

    

}
