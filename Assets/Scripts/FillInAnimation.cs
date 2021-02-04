using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using UnityEngine;

public class FillInAnimation : MonoBehaviour
{
    public RectTransform objectToScale;
    public float maxScale;
    public float waitBeforeFilling;
    private Vector3 currentScale;
    
    private void OnEnable()
    {
        currentScale = objectToScale.localScale;
        StartCoroutine(SizeInAnim());
    }
    
    IEnumerator SizeInAnim()
    {
        float i = 0;
        float rate = 1 / 0.25f;

        yield return  new WaitForSeconds(waitBeforeFilling);
        while (i < 1)
        {
            i += Time.deltaTime * rate;

            objectToScale.localScale = Vector2.Lerp(currentScale, new Vector2(maxScale, maxScale), i);

            yield return null;
        }
        
        currentScale = objectToScale.localScale;
        i = 0;
        
        while (i < 1)
        {
            i += Time.deltaTime * rate;

            objectToScale.localScale = Vector2.Lerp(currentScale, Vector2.one, i);

            yield return null;
        }
        
    }
}