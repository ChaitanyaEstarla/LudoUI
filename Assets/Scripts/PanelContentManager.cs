using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelContentManager : MonoBehaviour
{
    public List<GameObject> contentToReposition;
    public List<GameObject> contentToRescale;

    private List<Vector3> contentInitialPosition;
    private List<Vector3> contentInitialScale;

    private void OnEnable()
    {
        contentInitialPosition = new List<Vector3>();
        contentInitialScale = new List<Vector3>();
        for (int i = 0; i < contentToReposition.Count; i++)
        {
            contentInitialPosition.Add(contentToReposition[i].GetComponent<RectTransform>().anchoredPosition);
        }

        for (int j = 0; j < contentToRescale.Count; j++)
        {
            contentInitialScale.Add(contentToRescale[j].GetComponent<RectTransform>().localScale);
        }
    }

    private void OnDisable()
    {
        for (int i = 0; i < contentToReposition.Count; i++)
        {
            contentToReposition[i].GetComponent<RectTransform>().anchoredPosition = contentInitialPosition[i];
        }
        
        for (int j = 0; j < contentToRescale.Count; j++)
        {
            contentToRescale[j].GetComponent<RectTransform>().localScale = contentInitialScale[j];
        }
    }
}
