using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Lobby : ContainersDragAndDrop
{

    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = false;
    }

}
