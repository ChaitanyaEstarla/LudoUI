using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class MainMenuManager : MonoBehaviour
{
    public GameObject loadingScreen;
    private Button receivedButton;
    private Image bgColor;

    public AnimationCurve ggez;

    private void Start()
    {
        bgColor = loadingScreen.GetComponent<Image>();
    }

    //Loading Screen Coroutine
    IEnumerator LoadingScreen(GameObject objectToActivate, GameObject objectToDeactivate)
    {
        float j = 0;
        Color addAlpha = new Color(0,0,0,0.1f);
        
        /*
        objectToDeactivate.SetActive(false);
        loadingScreen.SetActive(true);
        while (j < 2)
        {
            j += 0.1f;
            
            if (j >= 1)
            {
                objectToActivate.SetActive(true);    
            }
            
            if (j < 1)
            {
                bgColor.color += addAlpha;
            }

            if (j > 1)
            {
                bgColor.color -= addAlpha;
            }
            yield return new WaitForSeconds(0.025f);
        }
        loadingScreen.SetActive(false);
        */
        
        objectToDeactivate.SetActive(false);
        loadingScreen.SetActive(true);
        while (j < 2)
        {
            j += 0.1f;
            
            if (j >= 1)
            {
                objectToActivate.SetActive(true);    
            }
            
            addAlpha.a = ggez.Evaluate(j);
            bgColor.color = addAlpha;
            
            yield return new WaitForSeconds(0.025f);
        }
        loadingScreen.SetActive(false);

        bgColor.color = new Color(0,0,0,0);
        
    }
    
    //Used to pass values to coroutine
    public void myMethod(GameObject objectToActivate, GameObject objectToDeactivate)
    {
        StartCoroutine(LoadingScreen(objectToActivate, objectToDeactivate));
    }
    
    //Empty Button 
    public void OnClick(GameObject gb)
    {
        Debug.Log(gb.name + " Clicked");
    }
}