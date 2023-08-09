using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectDragAndDrop : LoboMonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private CanvasGroup _canvasGroup;

    protected override void LoadComponents()
    {
        this._rectTransform = GetComponent<RectTransform>();
        this._canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        this._canvasGroup.alpha = .6f;
        this._canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this._rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this._canvasGroup.alpha = 1f;
        this._canvasGroup.blocksRaycasts = true;
    }

}
