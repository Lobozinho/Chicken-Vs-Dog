using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenPriceText : BaseText
{
    
    public void ShowChickenPriceText(int price)
    {
        this.text.text = price.ToString();
    }

}
