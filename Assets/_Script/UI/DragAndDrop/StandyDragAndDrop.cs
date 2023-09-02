using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StandyDragAndDrop : ContainersDragAndDrop
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = true;
    }

    protected override void SetIndexStandy(ObjectDragAndDrop objectDragAndDrop)
    {
        string standyName = transform.gameObject.name;
        char indexChar = standyName[standyName.Length - 1];
        int indexStandy = (int)indexChar;
        objectDragAndDrop.SetIndexStandy(indexStandy);
    }

}
