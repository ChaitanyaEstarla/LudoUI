using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Button uiButton;
    public MainMenuManager menuManager;

    public GameObject objectToActivate;
    public GameObject objectToDeactivate;
    
    public void OnButtonClicked()
    {
        menuManager.myMethod(objectToActivate, objectToDeactivate);
    }
    
    void Start()
    {
        uiButton.onClick.AddListener(OnButtonClicked);
    }
}
