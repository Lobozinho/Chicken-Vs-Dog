using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ContainerDragAndDrop : LoboMonoBehaviour, IDropHandler
{

    [SerializeField] private Image _containerImage;
    [SerializeField] private bool _isFull = false;

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

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        this._containerImage.enabled = false;
        this._isFull = true;
    }

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
        if (this._isFull) return;
        this._containerImage.enabled = true;
    }

    void DisabledContainerImage()
    {
        if (this._isFull) return;
        this._containerImage.enabled = false;
    }

}
