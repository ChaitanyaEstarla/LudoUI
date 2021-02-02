using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public AnimationClip anim;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(anim.length);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
