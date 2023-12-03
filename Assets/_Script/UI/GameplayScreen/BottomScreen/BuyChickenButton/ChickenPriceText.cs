using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenPriceText : BaseText
{
    
    [SerializeField] private int _chickenPrice = 1;
    public int ChickenPrice => _chickenPrice;
    
    public void ShowChickenPriceText()
    {
        this.text.text = this._chickenPrice.ToString();
    }

}
