using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject openingUI;
    public GameObject inGameUI;
    public GameObject endGameUI;
    public GameObject shopUI;
    public GameObject comingSoonUI;
    
    public int currentScore = 0;
    public Text scoreText;
    
    
 public void PlayButtonPressed()
    {
        GameManager.Instance.StartGame();
    }
    
    public void ShopButtonPressed()
    {
        openingUI.SetActive(false);
        inGameUI.SetActive(false);
        shopUI.SetActive(true);
    }
    
    public void ShopCloseButtonPressed()
    {
        openingUI.SetActive(true);
        inGameUI.SetActive(false);
        shopUI.SetActive(false);
    }

    public void StartGame()
    {
        openingUI.SetActive(false);
        inGameUI.SetActive(true);
        GameManager.Instance.score = PlayerPrefs.GetInt("score", 0);
        scoreText.text = currentScore.ToString();
    }
    
    public void ReplayGame()
    {
        openingUI.SetActive(true);
        inGameUI.SetActive(false);
        endGameUI.SetActive(false);
    }
    public void EndGame()
    {
        openingUI.SetActive(false);
        inGameUI.SetActive(false);
        endGameUI.SetActive(true);
    }

    public void ComingSoon()
    {
        GameManager.Instance.isGameStarted = false;
        comingSoonUI.SetActive(true);
        openingUI.SetActive(false);
        inGameUI.SetActive(false);
        endGameUI.SetActive(false);
        
    }
    
    public void CoinCollected(int currentScore)
    {
        scoreText.text = currentScore.ToString();
    }
    
    public void PrefSaving()
    {
        SaveScore();
        PlayerPrefs.Save();
    }
    public void SaveScore()
    {   
        PlayerPrefs.SetInt("score", GameManager.Instance.score);     
    }
}
