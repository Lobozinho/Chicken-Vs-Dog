using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CanvasGroup))]
[RequireComponent(typeof(BoxCollider2D))]

public abstract class ObjectDragAndDrop : LoboMonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [Header("Object Drag And Drop")]
    [SerializeField] protected CanvasGroup canvasGroup;
    [SerializeField] protected BoxCollider2D boxCollider2D;

    [SerializeField] protected Transform realParent;

    public void SetRealParent(Transform realParent)
    {
        this.realParent = realParent;
    }

    protected override void LoadComponents()
    {
        this.LoadCanvasGroup();
        this.LoadBoxCollider2D();
    }

    void LoadCanvasGroup()
    {
        if (this.canvasGroup != null) return;
        this.canvasGroup = GetComponent<CanvasGroup>();
        Debug.LogWarning(transform.name + ": LoadCanvasGroup", gameObject);
    }

    void LoadBoxCollider2D()
    {
        if (this.boxCollider2D != null) return;
        this.boxCollider2D = GetComponent<BoxCollider2D>();
        Debug.LogWarning(transform.name + ": LoadBoxCollider2D", gameObject);
    }

    public virtual void OnBeginDrag(PointerEventData eventData)
    {
        this.canvasGroup.alpha = .6f;
        this.canvasGroup.blocksRaycasts = false;
        this.realParent = transform.parent;
        Transform containersCtrl = UICtrl.Instance.DragAndDrop.ContainersCtrl.transform;
        transform.SetParent(containersCtrl);
    }

    // on being drag => on drag => on drop => on end drag

    public virtual void OnDrag(PointerEventData eventData)
    {
        this.ObjMoveByMouse();
        this.boxCollider2D.enabled = true;
    }

    void ObjMoveByMouse()
    {
        Vector3 mousePos = this.GetMousePos();
        mousePos.z = 0;
        transform.position = mousePos;
    }

    public virtual void OnEndDrag(PointerEventData eventData)
    {
        this.canvasGroup.alpha = 1f;
        this.canvasGroup.blocksRaycasts = true;
        transform.SetParent(this.realParent);
    }

    Vector3 GetMousePos()
    {
        return ManagerCtrl.Instance.InputManager.MouseWorldPos;
    }

}
