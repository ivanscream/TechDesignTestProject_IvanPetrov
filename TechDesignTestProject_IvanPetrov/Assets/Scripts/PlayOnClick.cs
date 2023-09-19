using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        anim.enabled = false;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.enabled = true;
        }
    }
}
