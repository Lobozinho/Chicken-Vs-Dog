using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StandyDragAndDrop : MonoBehaviour, IDropHandler
{

    [SerializeField] private string CHICKENS_TAG = "Chickens";

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount > 0) return;
        GameObject dropObj = eventData.pointerDrag;
        if (!dropObj.CompareTag(this.CHICKENS_TAG)) return;
        this.SetRealParent(dropObj);
        this.SetStandy(dropObj);
    }

    void SetRealParent(GameObject dropObj)
    {
        ObjectDragAndDrop objectDragAndDrop = dropObj.GetComponent<ObjectDragAndDrop>();
        objectDragAndDrop.SetRealParent(transform);
    }

    void SetStandy(GameObject dropObj)
    {
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIsStandy(true);
    }

}
