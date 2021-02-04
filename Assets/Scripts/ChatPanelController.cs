using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatPanelController : MonoBehaviour
{
    
    public GameObject objectToActivate;
    public GameObject objectesToDeactivate;
   
    public Button chatButton;
    
    public GameObject chatWindow;
    private Vector2 currentPos, destinationPos;

    private bool stateCheck;

    private void Start()
    {
        currentPos = chatWindow.GetComponent<RectTransform>().anchoredPosition;
        destinationPos = Vector2.zero;
        chatButton.onClick.AddListener(OnClickActivate);
    }

    public void OnClickActivate()
    {
        if (!stateCheck)
        {
            objectToActivate.SetActive(true);
            stateCheck = true;
            StartCoroutine(lerpAnim());
            
        }
        else if (stateCheck)
        {
            objectesToDeactivate.SetActive(false);
            stateCheck = false;
            StartCoroutine(lerpAnim());
        }
    }
    
    IEnumerator lerpAnim()
    {
        float i = 0;
        float rate = 1/0.5f;

        while (i < 1)
        {
            i += Time.deltaTime * rate;
            
            chatWindow.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(currentPos, destinationPos, i);
            
            yield return null;
        }
        destinationPos = currentPos;
        currentPos = chatWindow.GetComponent<RectTransform>().anchoredPosition;
    } 
}
