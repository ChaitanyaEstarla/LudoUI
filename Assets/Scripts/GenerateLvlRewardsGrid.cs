using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLvlRewardsGrid : MonoBehaviour
{
    public GameObject levelRewardPrefab;
    
    void Start()
    {
        //Instantiate(levelRewardPrefab);
        //levelRewardPrefab.transform.SetParent(gameObject.transform);
        
        GameObject temp = Instantiate(levelRewardPrefab);
        temp.transform.SetParent(transform);
        temp.transform.localScale=Vector3.one;
    }
}
