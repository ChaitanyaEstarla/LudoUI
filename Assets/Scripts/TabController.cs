using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class TabController : MonoBehaviour
{
    public List<TabContentManager> tabButton;
    public TabContentManager selectedTab;
    public List<GameObject> objectsToSwap;

    private void Start()
    {
        for (int i = 0; i < objectsToSwap.Count-1; i++)
        {
            objectsToSwap[i].SetActive(false);
        }
    }
    
    public void Subscribe(TabContentManager button)
    {
        if (tabButton == null)
        {
            tabButton = new List<TabContentManager>();
        }
        tabButton.Add(button);
        ResetTabs();
    }

    public void OnTabEnter(TabContentManager button)
    {
        ResetTabs();
    }

    public void OnTabExit(TabContentManager button)
    {
        ResetTabs();
    }
    
    public void OnTabSelected(TabContentManager button)
    {
        selectedTab = button;
        ResetTabs();
        button.backgroundImage.color = Color.white;
        button.GetComponentInChildren<TMP_Text>().color = new Color(0, 0.2784f,0.5921f,1);
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++)
        {
            if (index == i+1)
            {
                objectsToSwap[i].SetActive(true);
            }
            else
            {
                objectsToSwap[i].SetActive(false);
            }
        }
    }

    public void ResetTabs()
    {
        foreach (TabContentManager button in tabButton)
        {
            if (selectedTab != null && button == selectedTab){ continue; }

            button.GetComponent<Image>().color = new Color(1,1,1,0);
            button.GetComponentInChildren<TMP_Text>().color = new Color(0.1372f, 0.6901f,1,1);
        }
    }
}
