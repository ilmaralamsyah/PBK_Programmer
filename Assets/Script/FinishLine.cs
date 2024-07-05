using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private GameObject[] totalPlayer;

    private Scene scene;
    public int finishedPlayer;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        totalPlayer = GameObject.FindGameObjectsWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            finishedPlayer++;
            if(finishedPlayer >= totalPlayer.Length)
            {
                int nextSceneIndex = scene.buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        finishedPlayer--;
    }
}
