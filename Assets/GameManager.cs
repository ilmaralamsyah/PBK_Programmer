using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player prefabs;

    private Scene scene;

    private void Awake()
    {
        scene = SceneManager.GetActiveScene();

        for (int i = 0; i <= scene.buildIndex; i++)
        {
            Player playerPos = Instantiate(prefabs);
            playerPos.transform.position = this.transform.position;
        }
    }
}
