using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class BulletDamageSender : DamageSender
{

    [SerializeField] private const string DOG_TAG = "Dog";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(DOG_TAG)) return;
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();
        this.Send(damageReceiver);
    }

    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        this.DespawnBullet();
    }

    void DespawnBullet()
    {

    }

}
