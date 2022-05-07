using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShopManager : MonoBehaviour
{
    public int limitMoney = 50;
    public int playerMoney ;
    public Button buyButton;


    private void Start()
    {
        playerMoney = GameManager.Instance.score;
    }

    public void Update()
    {
        CheckEnoughMoney();
    }

    public void CheckEnoughMoney()
    {
        if (playerMoney < limitMoney)
        {
            buyButton.interactable = false;
        }
        if (playerMoney >= limitMoney)
        {
            buyButton.interactable = true;
        }
    }

    public void PlayerBought()
    {
        playerMoney -= limitMoney;
        GameManager.Instance.score = playerMoney;
    }
    
}
