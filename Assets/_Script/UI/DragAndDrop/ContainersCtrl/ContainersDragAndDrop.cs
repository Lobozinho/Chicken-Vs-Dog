using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ContainersDragAndDrop : LoboMonoBehaviour, IDropHandler
{
    [Header("ContainersDragAndDrop")]
    [SerializeField] protected const string CHICKENS_TAG = "Chickens";
    [SerializeField] protected const string SHIELD_TAG = "Shield";
    [SerializeField] protected const string DOG_TAG = "Dog";

    [SerializeField] protected Image image;
    [SerializeField] protected float alphaDropping = 0.5f;
    [SerializeField] protected float alphaEndDrop = 0;

    [SerializeField] protected bool isStandy;

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
        this.SetIsStandy(dropObj);
        this.ChangeAlphaImage(this.alphaEndDrop);
    }

    protected abstract void ChangeColorImage(GameObject collision);
    //if (transform.childCount > 0) return;
    //if (collision.CompareTag(SHIELD_TAG)) this.ChangeRedImage();
    //else if (collision.CompareTag(CHICKENS_TAG)) this.ChangeWhiteImage();

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
    //if (!this.CheckPrefab(dropObj)) return;
    //ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
    //objectDragAndDrop.SetRealParent(transform);

    //protected virtual bool CheckPrefab(GameObject dropObj)
    //{
    //    if (dropObj.CompareTag(CHICKENS_TAG)) return true;
    //    return false;
    //}

    void SetIsStandy(GameObject dropObj)
    {
        if (!dropObj.CompareTag(CHICKENS_TAG)) return;
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIsStandy(this.isStandy);
    }

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

}
