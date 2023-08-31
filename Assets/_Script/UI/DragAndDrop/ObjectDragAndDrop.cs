using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectDragAndDrop : LoboMonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    //[SerializeField] private RectTransform _rectTransform;
    //[SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Transform _realParent;
    [SerializeField] private Image _image;

    public void SetRealParent(Transform realParent)
    {
        this._realParent = realParent;
    }

    protected override void LoadComponents()
    {
        //this._rectTransform = GetComponent<RectTransform>();
        //this._canvasGroup = GetComponent<CanvasGroup>();
        this.LoadImage();
    }

    void LoadImage()
    {
        if (this._image != null) return;
        this._image = GetComponent<Image>();
        Debug.Log(transform.name + ": LoadImage", gameObject);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //this._canvasGroup.alpha = .6f;
        //this._canvasGroup.blocksRaycasts = false;
        this._realParent = transform.parent;
        transform.SetParent(UICtrl.Instance.transform);
        this._image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //this._rectTransform.anchoredPosition += eventData.delta;
        Vector3 mousePos = this.GetMousePos();
        mousePos.z = 0;
        transform.position = mousePos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //this._canvasGroup.alpha = 1f;
        //this._canvasGroup.blocksRaycasts = true;
        transform.SetParent(this._realParent);
        this._image.raycastTarget = true;
    }

    Vector3 GetMousePos()
    {
        return ManagerCtrl.Instance.InputManager.MouseWorldPos;
    }

}
