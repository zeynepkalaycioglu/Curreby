using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public void CoinCollected(GameObject coin)
    {

        coin.gameObject.SetActive(false);

    }
    
    public void DiamondCollected(GameObject diamond)
    {

        diamond.gameObject.SetActive(false);

    }
}
