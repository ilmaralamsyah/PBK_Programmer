using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonUI : MonoBehaviour
{
    [SerializeField] private Border border;
    [SerializeField] private float rotationSpeed;


    private bool onHoldRotateLeft = false;
    private bool onHoldRotateRight = false;
    
    private void Update()
    {
        if (onHoldRotateLeft)
        {
            border.transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
        if (onHoldRotateRight)
        {
            border.transform.Rotate(-Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }

    public void RotateLeftButtonHold()
    {
        onHoldRotateLeft = true;
    }

    public void RotateLeftButtonUp()
    {
        onHoldRotateLeft = false;
    }

    public void RotateRightButtonHold()
    {
        onHoldRotateRight = true;
    }

    public void RotateRightButtonUp()
    {
        onHoldRotateRight = false;
    }
}
