using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LobbyDragAndDrop : LoboMonoBehaviour, IDropHandler
{

    [SerializeField] private Image _containerImage;
    [SerializeField] private string CHICKENS_TAG = "Chickens";

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadContainerImage();
    }

    void LoadContainerImage()
    {
        if (this._containerImage != null) return;
        this._containerImage = GetComponent<Image>();
        Debug.LogWarning(transform.name + ": LoadContainerImage", gameObject);
    }

    //public void OnDrop(PointerEventData eventData)
    //{
    //    Debug.Log("OnDrop");
    //    //if (eventData.pointerDrag == null) return;
    //    //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
    //    //this._containerImage.enabled = false;
    //    GameObject dropObj = eventData.pointerDrag;
    //    ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
    //    //if (objectDragAndDrop == null) Debug.Log("objectDragAndDrop");
    //    objectDragAndDrop.SetRealParent(transform);
    //}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        this.OnEnabledContainerImage();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        this.DisabledContainerImage();
    }

    void OnEnabledContainerImage()
    {
        if (transform.childCount > 0) return;
        this._containerImage.enabled = true;
    }

    void DisabledContainerImage()
    {
        if (transform.childCount > 0) return;
        this._containerImage.enabled = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0) return;
        GameObject dropObj = eventData.pointerDrag;
        if (!dropObj.CompareTag(this.CHICKENS_TAG)) return;
        ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
        objectDragAndDrop.SetRealParent(transform);
    }
}
