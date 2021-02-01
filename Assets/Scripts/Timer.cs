using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float startTimer = 0f;
    float timer;
    
    void Start()
    {
        StartCoroutine(GoldsChestTimer());
        
    }

    private IEnumerator GoldsChestTimer()
    {
        timer = startTimer;

        do
        {
            timer -= 1;
            TimeFormat();
            yield return new WaitForSeconds(1);
        } 
        while (timer > 0);
    }

    private void TimeFormat()
    {
        int days = (int) (timer / 86400) % 365;
        int hours = (int) (timer / 3600) % 24;
        int minutes = (int) (timer / 60) % 60;
        int seconds = (int) timer % 60;

        GetComponent<TMP_Text>().text = days + "d " + hours + "h " + minutes + "m " + seconds + "s";
    }
}
