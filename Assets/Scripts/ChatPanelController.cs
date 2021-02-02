using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatPanelController : MonoBehaviour
{
    
    public GameObject objectToActivate;
    public GameObject objectesToDeactivate;
    public Button myButton;

    private bool stateCheck;

    private void Start()
    {
        myButton.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        StartCoroutine(OnClickActivate());
    }

    IEnumerator OnClickActivate()
    {
        if (stateCheck == false)
        {
            yield return new WaitForSeconds(1);
            objectToActivate.SetActive(true);
            stateCheck = true;
            Debug.Log("GG");
        }
        else if (stateCheck == true)
        {
            objectesToDeactivate.SetActive(false);
            stateCheck = false;
            Debug.Log("EZ");
        }

    }
}
