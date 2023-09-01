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

}
