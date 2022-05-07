using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private Vector3 firstPos, endPos;
    public Vector3 playerStartPos;

    public GameObject player;
    public float playerSpeed = 0.1f;
    public float playerMovingForward = 0.1f;

    public PlayerCollectible playerCollectible;
    void Update()
    {
        if (GameManager.Instance.isGameStarted || playerCollectible.CompareTag("Ground"))
        {
             MovingPlayer();
        }
       
    }


    public void MovingPlayer()
    {

        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;

            float xDiff = endPos.x - firstPos.x;
            transform.Translate(xDiff * Time.deltaTime * playerSpeed/100,0,playerMovingForward);
        }

        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }
    }

    public void ReplayGame()
    {
        player.transform.position = playerStartPos;
    }
    
    

}
