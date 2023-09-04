using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class ContainersDragAndDrop : LoboMonoBehaviour, IDropHandler
{
    [Header("ContainersDragAndDrop")]
    [SerializeField] protected const string CHICKENS_TAG = "Chickens";
    [SerializeField] protected Image image;
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

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0) return;

        GameObject dropObj = eventData.pointerDrag;
        if (!dropObj.CompareTag(CHICKENS_TAG)) return;
        
        this.SetRealParent(dropObj);
        this.SetIndexStandy(dropObj);
        this.SetIsStandy(dropObj);
    }

    void SetRealParent(GameObject dropObj)
    {
        ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
        objectDragAndDrop.SetRealParent(transform);
    }

    void SetIsStandy(GameObject dropObj)
    {
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIsStandy(this.isStandy);
    }

    protected virtual void SetIndexStandy(GameObject dropObj) {}

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //this.OnEnabledContainerImage();
    //    Debug.Log("OnTriggerEnter2D");
    //    Color imageColor = image.color;
    //    imageColor.a = 0.5f;
    //    image.color = imageColor;
    //}

    //public void OnTriggerExit2D(Collider2D collision)
    //{
    //    Debug.Log("OnTriggerExit2D");
    //    Color imageColor = image.color;
    //    imageColor.a = 0f;
    //    image.color = imageColor;
    //    //this.DisabledContainerImage();
    //}

    //void OnEnabledContainerImage()
    //{
    //    if (transform.childCount > 0) return;
    //    this._containerImage.enabled = true;
    //}

    //void DisabledContainerImage()
    //{
    //    if (transform.childCount > 0) return;
    //    this._containerImage.enabled = false;
    //}

}
