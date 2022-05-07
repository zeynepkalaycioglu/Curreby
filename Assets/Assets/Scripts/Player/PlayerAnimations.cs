using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
   public Animator playerAnimator;

   private void Update()
   {
      if (GameManager.Instance.isGameStarted)
      {
         CheckingPlayerStates();
      }
   }

   public void CheckingPlayerStates()
   {
      if (GameManager.Instance.uiManager.currentScore == 0)
      {
         BaseRun();
      }
      if (GameManager.Instance.score >= 1)
      {
         CollectedCoin();
      }
      
   }

   public void CollectedCoin()
   {
      playerAnimator.SetBool("isRunningWithStack", true);
      playerAnimator.SetBool("isRunning", false);
      playerAnimator.SetBool("isGameEnded", false);
   }
   public void BaseRun()
   {
      playerAnimator.SetBool("isRunning", true);
      playerAnimator.SetBool("isGameEnded", false);
      playerAnimator.SetBool("isRunningWithStack", false);
   }
   public void EndingDance()
   {
      playerAnimator.SetBool("isGameEnded", true);
      playerAnimator.SetBool("isRunning", false);
      playerAnimator.SetBool("isRunningWithStack", false);
   }
   
   public void ReplayGame()
   {
      playerAnimator.SetBool("isGameEnded", false);
      playerAnimator.SetBool("isRunning", false);
      playerAnimator.SetBool("isRunningWithStack", false);
   }
}
