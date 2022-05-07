using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public bool isLevelCompleted = false;
    public string nextLevel;
    public void IsLevelCompleted()
    {
        isLevelCompleted = true;
        if (isLevelCompleted)
        {
            LevelCompleted();
        }
    }
    
    public void LevelCompleted()
    {
        StartCoroutine(LoadSceneWithDelay());
    }
    
    public IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(0.5f);

        if (nextLevel != null)
        {
            SceneManager.LoadScene(nextLevel);
        }
        
        if (nextLevel == null)
        {
            GameManager.Instance.uiManager.ComingSoon();
        }
        isLevelCompleted = false;
    }



}
