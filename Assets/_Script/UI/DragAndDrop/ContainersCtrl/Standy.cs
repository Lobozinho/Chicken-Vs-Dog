using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

public class Standy : ContainersDragAndDrop
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = true;
    }

    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        GameObject dropObj = eventData.pointerDrag;
        this.SetIndexStandy(dropObj);
    }

    void SetIndexStandy(GameObject dropObj)
    {
        if (!dropObj.CompareTag(CHICKENS_TAG)) return;
        string standyName = transform.gameObject.name;
        char indexChar = standyName[standyName.Length - 1];
        int indexStandy = int.Parse(indexChar.ToString());
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIndexStandy(indexStandy);
    }

    protected override void ChangeColorImage(GameObject collision)
    {

    }

    protected override void SetRealParent(GameObject dropObj)
    {

    }
}
