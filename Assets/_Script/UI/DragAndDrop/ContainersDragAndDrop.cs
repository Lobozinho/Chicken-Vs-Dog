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

}
