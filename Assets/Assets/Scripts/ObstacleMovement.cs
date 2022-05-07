using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMovement : ObjectMoving
{
    
    void Start()
    {
        transform.DORotate(new Vector3(0,0,-180f),rotateSpeed,RotateMode.LocalAxisAdd).SetLoops(-1).SetEase(Ease.InCirc);
    }
    
   
}
