using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
     
    public bool isGameStarted = false;
    
    public UIManager uiManager;
    public CollectibleManager collectibleManager;
    public LevelManager levelManager;
    public PlayerMovement playerMovement;
    public PlayerAnimations playerAnimations;
    public StackBar stackBar;
    
    
    public int score = 0;
    public int playerDecreasingCoinAmount = 1;
    public int playerIncreasingCoinAmount = 0;

    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void StartGame()
    {
        isGameStarted = true;
        uiManager.StartGame();
        SoundManager.Instance.PlayBgMusic(SoundManager.BgMusicTypes.MainBgMusic);
    }
    
    public void EndGame()
    {
        SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Congratz);
        isGameStarted = false;
        uiManager.EndGame();
        uiManager.PrefSaving();
        playerAnimations.EndingDance();
    }
    
    public void ReplayGame()
    {
        uiManager.ReplayGame();
        playerMovement.ReplayGame();
        playerAnimations.ReplayGame();
        levelManager.IsLevelCompleted();
    }
    public void CoinCollected(GameObject coin)
    {
        playerAnimations.CollectedCoin();
        score++;
        
        uiManager.CoinCollected(score);   
        collectibleManager.CoinCollected(coin);
        stackBar.SetStack(score);
        
        stackBar.SetMaxStackAmount(5 + playerIncreasingCoinAmount);
       
    }

    public void DiamondCollected(GameObject diamond)
    {
        playerAnimations.CollectedCoin();
        playerIncreasingCoinAmount++;
        Debug.Log("increasing " + playerIncreasingCoinAmount);
        collectibleManager.DiamondCollected(diamond);
        stackBar.SetMaxStackAmount(playerIncreasingCoinAmount);
    }
    public void PlayerCrashedObstacle()
    {
        score -= playerDecreasingCoinAmount;
        stackBar.SetStack(score);
    }
    
    
    
}
