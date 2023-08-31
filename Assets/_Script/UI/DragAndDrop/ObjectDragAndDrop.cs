using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectDragAndDrop : LoboMonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    //[SerializeField] private RectTransform _rectTransform;
    //[SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Transform realParent;

    //protected override void LoadComponents()
    //{
    //    this._rectTransform = GetComponent<RectTransform>();
    //    this._canvasGroup = GetComponent<CanvasGroup>();
    //}

    public void OnBeginDrag(PointerEventData eventData)
    {
        //this._canvasGroup.alpha = .6f;
        //this._canvasGroup.blocksRaycasts = false;
        this.realParent = transform.parent;
        transform.parent = UICtrl.Instance.transform;
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
        transform.parent = this.realParent;
    }

    Vector3 GetMousePos()
    {
        return ManagerCtrl.Instance.InputManager.MouseWorldPos;
    }

}
