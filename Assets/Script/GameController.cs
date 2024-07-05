using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject prefab1;

    float counter;
  
    private void Update()
    {
        counter += Time.deltaTime;
        if(counter > 2)
        {
            Instantiate(prefab1);
            counter = 0f;
        }
    }
}
