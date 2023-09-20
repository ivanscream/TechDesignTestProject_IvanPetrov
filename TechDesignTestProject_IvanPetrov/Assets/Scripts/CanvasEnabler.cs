using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEnabler : MonoBehaviour
{
    public GameObject canvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canvas != null)
        {
            canvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && canvas != null)
        {
            canvas.SetActive(false);
        }
    }
}
