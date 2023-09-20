using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellHoundRun : MonoBehaviour
{
    private Animator animator;
    public float dogSpeed;
    private bool shouldRun;
    private AudioSource audioSource;

    void Start()
    {
        animator = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();
        shouldRun = false;
    }

    private void Update()
    {
        if (shouldRun == true)
            transform.Translate(transform.right * dogSpeed * Time.deltaTime);
        else return;
            
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Run");
            Destroy(this.gameObject, 10f);
            shouldRun = true;
            audioSource.Play();
        }
    }
}
