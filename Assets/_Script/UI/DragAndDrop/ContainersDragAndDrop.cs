using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ContainersDragAndDrop : LoboMonoBehaviour, IDropHandler
{
    [Header("ContainersDragAndDrop")]
    [SerializeField] protected const string CHICKENS_TAG = "Chickens";
    [SerializeField] protected bool isStandy;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0) return;

        GameObject dropObj = eventData.pointerDrag;
        if (!dropObj.CompareTag(CHICKENS_TAG)) return;
        
        ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
        
        this.SetRealParent(objectDragAndDrop);
        this.SetIndexStandy(objectDragAndDrop);
        this.SetStandy(dropObj);
    }

    void SetRealParent(ObjectDragAndDrop objectDragAndDrop)
    {
        objectDragAndDrop.SetRealParent(transform);
    }

    void SetStandy(GameObject dropObj)
    {
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIsStandy(this.isStandy);
    }

    protected virtual void SetIndexStandy(ObjectDragAndDrop objectDragAndDrop) {}    

}
