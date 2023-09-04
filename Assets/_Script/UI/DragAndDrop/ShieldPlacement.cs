using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPlacement : ContainersDragAndDrop
{
    protected override void ChangeColorImage(GameObject collision)
    {
        if (transform.childCount > 0) return;
        if (collision.CompareTag(SHIELD_TAG)) this.ChangeWhiteImage();
        else if (collision.CompareTag(CHICKENS_TAG)) this.ChangeRedImage();
    }

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
