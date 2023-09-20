using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private Scene scene;
    public string sceneOne, sceneTwo;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    public void ClickLoadScene()
    {
        if (scene.name == sceneOne)
            SceneManager.LoadScene("scene_two");

        if (scene.name == sceneTwo)
            SceneManager.LoadScene("scene_one");
    }
}
