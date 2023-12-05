using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpGradePriceText : BaseText
{
   
    public void ShowUpGradePrice(int price)
    {
        this.text.text = price.ToString();
    }

}
