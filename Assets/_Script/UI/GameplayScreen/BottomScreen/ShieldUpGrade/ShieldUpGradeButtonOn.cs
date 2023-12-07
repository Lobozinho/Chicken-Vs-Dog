using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldUpGradeButtonOn : BaseButton
{
    
    protected override void OnClick()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            if (!shield.IsSelected) continue;
            shield.Upgrade.ShieldUpgraded();
        }
    }

}
