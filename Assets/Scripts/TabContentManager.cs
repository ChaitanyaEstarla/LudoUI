using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

    
[RequireComponent(typeof(Image))]    
public class TabContentManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public TabController tabController;
    public Image backgroundImage;
    
    void Start()
    {
        backgroundImage = GetComponent<Image>();
        tabController.Subscribe(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabController.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabController.OnTabExit(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabController.OnTabSelected(this);
    }
}
