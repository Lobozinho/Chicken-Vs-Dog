using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenShooting : MonoBehaviour
{
    
    [SerializeField] private bool _isShooting = false;
    [SerializeField] private bool _isStandy = false;

    [SerializeField] private float _shootDelay = 1f;
    [SerializeField] private float _shootTimer = 0f;

    public void SetIsStandy(bool value)
    {
        this._isStandy = value;
    }

    private void FixedUpdate()
    {
        this.Shooting();
    }

    void Shooting()
    {
        if (!this._isShooting) return;
        if(!this._isStandy) return;
        if (this.CheckDelayTime()) return;
        ManagerCtrl.Instance.SpawnerManager.BulletSpawning(transform.parent.position);
    }

    bool CheckDelayTime()
    {
        this._shootTimer += Time.fixedDeltaTime;
        if (this._shootTimer < this._shootDelay) return true;
        this._shootTimer = 0;
        return false;
    }

}
