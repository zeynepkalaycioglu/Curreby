using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectible : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("Coin"))
        {
            Debug.Log("collided coin");
            collision.GetComponent<SphereCollider>().enabled = false;
            GameManager.Instance.CoinCollected(collision.gameObject);
            SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Collect);
        }
        
        if (collision.transform.CompareTag("Diamond"))
        {
            collision.GetComponent<SphereCollider>().enabled = false;
            GameManager.Instance.DiamondCollected(collision.gameObject);
            SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Collect);
        }

        if (collision.transform.CompareTag("Obstacle"))
        {
            GameManager.Instance.PlayerCrashedObstacle();
            SoundManager.Instance.PlaySound(SoundManager.SoundTypes.Crash);
        }
        
        if (collision.transform.CompareTag("WinDetector"))
        {
            GameManager.Instance.EndGame();
        }
        
        if (collision.transform.CompareTag("Ground"))
        {
         
        }
        
    }
}
