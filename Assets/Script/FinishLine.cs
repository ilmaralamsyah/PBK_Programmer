using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            int nextSceneIndex = scene.buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
