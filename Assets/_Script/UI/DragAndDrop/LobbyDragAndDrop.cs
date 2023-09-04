using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LobbyDragAndDrop : ContainersDragAndDrop
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
    }
    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = false;
    }

}
