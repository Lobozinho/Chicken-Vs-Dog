using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExp : BaseSlider
{
    
    public void ShowExpSlider(float newValue)
    {
        this.OnChanged(newValue);
    }
    
    protected override void OnChanged(float newValue)
    {
        this.slider.value = newValue;
    }

}
