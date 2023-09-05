using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDamageReceiver : DamageReceiver
{
    protected override void OnDead()
    {
        Debug.Log("OnDead");
        this.Despawn();    
    }

    void Despawn()
    {

    }


}
