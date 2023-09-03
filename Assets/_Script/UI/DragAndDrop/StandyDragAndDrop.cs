using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.TextCore.Text;

public class StandyDragAndDrop : ContainersDragAndDrop
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = true;
    }

    protected override void SetIndexStandy(GameObject dropObj)
    {
        string standyName = transform.gameObject.name;
        char indexChar = standyName[standyName.Length - 1];
        int indexStandy = int.Parse(indexChar.ToString());
        ChickenShooting chickenShooting = dropObj.GetComponentInChildren<ChickenShooting>();
        chickenShooting.SetIndexStandy(indexStandy);
    }

}
