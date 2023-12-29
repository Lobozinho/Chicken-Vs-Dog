using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ContainersDragAndDrop : LoboMonoBehaviour, IDropHandler, IPointerClickHandler
{
    [Header("ContainersDragAndDrop")]
    [SerializeField] protected const string CHICKENS_TAG = "Chickens";
    [SerializeField] protected const string SHIELD_TAG = "Shield";
    [SerializeField] protected const string DOG_TAG = "Dog";

    [SerializeField] protected Image image;
    [SerializeField] protected float alphaDropping = 0.5f;
    [SerializeField] protected float alphaEndDrop = 0;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadImage();
    }

    void LoadImage()
    {
        if (this.image != null) return;
        this.image = GetComponent<Image>();
        Debug.LogWarning(transform.name + ": LoadImage", gameObject);
    }

    public virtual void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0) return;
        GameObject dropObj = eventData.pointerDrag;
        this.SetRealParent(dropObj);
        this.ChangeAlphaImage(this.alphaEndDrop);
    }

    protected abstract void ChangeColorImage(GameObject collision);

    protected virtual void ChangeRedImage()
    {
        Color redColor = Color.red;
        this.image.color = redColor;
    }

    protected virtual void ChangeWhiteImage()
    {
        Color whiteColor = Color.white;
        this.image.color = whiteColor;
    }

    protected abstract void SetRealParent(GameObject dropObj);

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(DOG_TAG)) return;
        this.ChangeColorImage(collision.gameObject);
        this.ChangeAlphaImage(this.alphaDropping);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(DOG_TAG)) return;
        this.ChangeColorImage(collision.gameObject);
        this.ChangeAlphaImage(this.alphaEndDrop);
    }

    void ChangeAlphaImage(float alphaValue)
    {
        if (transform.childCount > 0) return;
        Color imageColor = image.color;
        imageColor.a = alphaValue;
        image.color = imageColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("DontUpgradeShield");
        UICtrl.Instance.GameplayScreen.BottomScreen.ShieldUpgrade.DontUpgradeShield();
    }
}
