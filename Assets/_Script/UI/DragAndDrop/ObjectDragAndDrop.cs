using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObjectDragAndDrop : LoboMonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    //[SerializeField] private RectTransform _rectTransform;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Image _image;
    [SerializeField] private ChickenShooting _chickenShooting;

    [SerializeField] private Transform _realParent;
    
    public void SetRealParent(Transform realParent)
    {
        this._realParent = realParent;
    }

    public void SetIndexStandy(int indexStandy)
    {
        this._chickenShooting.SetIndexStandy(indexStandy);
    }

    protected override void LoadComponents()
    {
        //this._rectTransform = GetComponent<RectTransform>();
        this.LoadCanvasGroup();
        this.LoadChickenShooting();
        //this.LoadImage(); 
    }

    void LoadImage()
    {
        if (this._image != null) return;
        this._image = GetComponent<Image>();
        Debug.Log(transform.name + ": LoadImage", gameObject);
    }

    void LoadCanvasGroup()
    {
        if (this._canvasGroup != null) return;
        this._canvasGroup = GetComponent<CanvasGroup>();
        Debug.LogWarning(transform.name + ": LoadCanvasGroup", gameObject);
    }

    void LoadChickenShooting()
    {
        if (this._chickenShooting != null) return;
        this._chickenShooting = GetComponentInChildren<ChickenShooting>();
        Debug.LogWarning(transform.name + ": LoadChickenShooting", gameObject);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        this._canvasGroup.alpha = .6f;
        this._canvasGroup.blocksRaycasts = false;
        this._realParent = transform.parent;
        transform.SetParent(ContainersCtrl.Instance.transform);
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
        this._canvasGroup.alpha = 1f;
        this._canvasGroup.blocksRaycasts = true;
        transform.SetParent(this._realParent);
        this._image.raycastTarget = true;
    }

    Vector3 GetMousePos()
    {
        return ManagerCtrl.Instance.InputManager.MouseWorldPos;
    }

}
