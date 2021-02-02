using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;

    public Button myButton;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
         objectToActivate.SetActive(true);
         objectToDeactivate.SetActive(false);
    }

    public void OnClick(GameObject gb)
    {
        Debug.Log(gb.transform.name + " Clicked");
    }
}