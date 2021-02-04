using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideInAnimation : MonoBehaviour
{
    public RectTransform values;
    private Vector3 currentPos;
    //public GameObject mainPanel;
    public float newX;
    public float newY;
    
    
    private void OnEnable()
    {
        currentPos = values.anchoredPosition;
        StartCoroutine(lerpAnim());
    }
    
    IEnumerator lerpAnim()
    {
        float i = 0;
        float rate = 1 / 0.5f;

        yield return  new WaitForSeconds(0.15f);
        while (i < 1)
        {
            i += Time.deltaTime * rate;
            
            values.anchoredPosition = Vector2.Lerp(currentPos, new Vector3(newX, newY), i);
            
            yield return null;
        }
    }
}
