using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveButtonOn : BaseButton
{
    
    protected override void OnClick()
    {
        this.CheckShieldPrefab();
        
    }

    private void CheckShieldPrefab()
    {
        ShieldPrefab[] allShields = FindObjectsOfType<ShieldPrefab>();
        foreach (ShieldPrefab shield in allShields)
        {
            if (!shield.IsSelected) continue;
            shield.Upgrade.ShieldUpgraded();
        }
    }

}
