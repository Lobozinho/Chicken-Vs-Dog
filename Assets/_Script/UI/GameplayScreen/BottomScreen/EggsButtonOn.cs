using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggsButtonOn : BaseButton
{
    protected override void OnClick()
    {
        gameObject.SetActive(false);
        // l�m ch?c n?ng spawn chicken 
    }

}
