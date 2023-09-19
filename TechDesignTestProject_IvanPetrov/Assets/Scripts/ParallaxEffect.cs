using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public float parallaxIntensity = 1.0f;
    private Transform playerTransform;
    private Vector3 previousPlayerPosition;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        previousPlayerPosition = playerTransform.position;
    }

    private void Update()
    {
        float deltaX = playerTransform.position.x - previousPlayerPosition.x;
        float deltaY = playerTransform.position.y - previousPlayerPosition.y;
        
        Vector3 newPosition = transform.position + new Vector3
            (deltaX * parallaxIntensity, deltaY * parallaxIntensity, 0);

        transform.position = newPosition;
        
        previousPlayerPosition = playerTransform.position;
    }

}
