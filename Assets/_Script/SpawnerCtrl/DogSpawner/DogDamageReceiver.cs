using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class DogDamageReceiver : DamageReceiver
{

    protected override void OnDead()
    {
        Debug.Log("OnDead");
    }

}
