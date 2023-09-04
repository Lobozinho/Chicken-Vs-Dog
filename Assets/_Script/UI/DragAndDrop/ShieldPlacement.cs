using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPlacement : ContainersDragAndDrop
{
   
    protected override bool CheckPrefab(GameObject dropObj)
    {
        if (dropObj.CompareTag(SHIELD_TAG)) return true;
        return false;
    }

    protected override void ResetValue()
    {
        base.ResetValue();
        this.isStandy = false;
    }

}
