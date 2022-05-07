using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StackBar : MonoBehaviour
{
   public Slider slider;

  

   public void SetMaxStackAmount(int playerCoinAmount)
   {
       slider.maxValue = playerCoinAmount;
   }
   
   public void SetStack(int coinAmount)
   {
      slider.value = coinAmount;
   }
}
