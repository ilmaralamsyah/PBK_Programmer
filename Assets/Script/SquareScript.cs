using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float moveSpeed;

    void Update()
    {
        transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime * moveSpeed);
    }
}
