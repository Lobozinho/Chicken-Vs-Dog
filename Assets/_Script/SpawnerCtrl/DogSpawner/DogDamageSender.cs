using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class DogDamageSender : DamageSender
{

    [SerializeField] private const string CHICKEN_TAG = "Chickens";
    [SerializeField] private const string SHIELD_TAG = "Shield";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag(CHICKEN_TAG) && !collision.CompareTag(SHIELD_TAG)) return;
        Debug.Log("OnTriggerEnter2D");
        //DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();
        //this.Send(damageReceiver);

    }

}
