using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;
using TMPro;

public class GameplayShopScrollController : MonoBehaviour
{
    public List<GameplayShopTabController> tabContent;
    public GameplayShopTabController selectedTab;
    public RectTransform gameplayScrollRect;

    private int currentTab = 0; 
    private GameObject tabLogo;
    public void Subscribe(GameplayShopTabController button)
    {
        if (tabContent == null)
        {
            tabContent = new List<GameplayShopTabController>();
            tabContent.Add(button);
        }
        ResetTabs();
    }

    public void OnButtonSelected(GameplayShopTabController button)
    {
        selectedTab = button;
        ResetTabs();
        button.backgroundImage.color = Color.white;
        button.GetComponentInChildren<TMP_Text>().color = new Color(0, 0.2784f,0.5921f,1);
        tabLogo = button.transform.GetChild(1).gameObject;
        tabLogo.GetComponent<Image>().color = new Color(0, 0.2784f,0.5921f,1);
        
        int index = button.transform.GetSiblingIndex();
        int tabSetter = index;
        float offset;

        if (tabSetter == currentTab)
        {
            offset = 0;
        }
        else
        {
            if (tabSetter > 2)
            {
                tabSetter = 2;
            }
            offset = 2.3f * (tabSetter - currentTab);
        }
        
        Debug.Log(offset);
        Vector2 destinationPosition =
            gameplayScrollRect.localPosition + new Vector3(0, (gameplayScrollRect.GetChild(0).localPosition.y / gameplayScrollRect.childCount) * offset);
        
        switch (index)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
                StartCoroutine(scrollContent(gameplayScrollRect.localPosition, destinationPosition));
                currentTab = tabSetter;
                if (currentTab > 2)
                {
                    currentTab = 0;
                }
                break;
        } 
    }

    public void ResetTabs()
    {
        foreach (GameplayShopTabController button in tabContent)
        {     
            if (selectedTab != null && button == selectedTab){ continue; }

            button.GetComponent<Image>().color = new Color(1,1,1,0);
            button.GetComponentInChildren<TMP_Text>().color = new Color(0.1372f, 0.6901f,1,1);
            tabLogo = button.transform.GetChild(1).gameObject;
            tabLogo.GetComponent<Image>().color = new Color(0.1372f, 0.6901f,1,1);
        }
    }

    IEnumerator scrollContent(Vector2 currentPosition, Vector2 destinationPosition)
    {
        float smooting = 0;
        float second = 0.01f;
        while (smooting <= 1)
        {
            gameplayScrollRect.localPosition = Vector2.Lerp(currentPosition, destinationPosition, smooting);  
            smooting += 0.1f;
            yield return new WaitForSeconds(second);
        }
        
    }
}
