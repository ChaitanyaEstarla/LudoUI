using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameplayShopTabController : MonoBehaviour, IPointerClickHandler
{
    public GameplayShopScrollController tabController;
    public Image backgroundImage;
    
    void Start()
    {
        backgroundImage = GetComponent<Image>();
        tabController.Subscribe(this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabController.OnButtonSelected(this);
    }
}
