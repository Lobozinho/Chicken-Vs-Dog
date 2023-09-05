using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class DogDamageSender : DamageSender
{
    [Header("Dog Damage Sender")]
    [SerializeField] private const string CHICKEN_TAG = "Chickens";
    [SerializeField] private const string SHIELD_TAG = "Shield";
    [SerializeField] private const string DAMAGE_RECEIVER = "DamageReceiver";

    [SerializeField] private DogPrefabCtrl _ctrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadDogPrefabCtrl();
    }

    void LoadDogPrefabCtrl()
    {
        if (this._ctrl != null) return;
        this._ctrl = GetComponentInParent<DogPrefabCtrl>();
        Debug.LogWarning(transform.name + ": LoadDogPrefabCtrl", gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != DAMAGE_RECEIVER) return;
        if (!collision.CompareTag(CHICKEN_TAG) && !collision.CompareTag(SHIELD_TAG)) return;
        this._ctrl.DogMovement.Stop();
        this.SetAnimationAttack(true);
        this.SendDamage(collision);
    }

    void SetAnimationAttack(bool value)
    {
        this._ctrl.Animation.SetAttack(value);
    }

    void SendDamage(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();
        this.Send(damageReceiver);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag(CHICKEN_TAG) && !collision.CompareTag(SHIELD_TAG)) return;
        this.SetAnimationAttack(false);
        this._ctrl.DogMovement.Moving();
    }    

}
