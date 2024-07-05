using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotateButton : MonoBehaviour
{
    [SerializeField] private HoldButton rotateRightButton;
    [SerializeField] private HoldButton rotateLeftButton;

    [SerializeField] private Border border;
    [SerializeField] private float rotationSpeed;

    private bool OnHoldRightButton = false;
    private bool OnHoldLeftButton = false;

    private void Start()
    {
        rotateRightButton.OnHoldButtonDown += RotateRightButton_OnHoldButtonDown;
        rotateRightButton.OnHoldButtonUp += RotateRightButton_OnHoldButtonUp;

        rotateLeftButton.OnHoldButtonDown += RotateLeftButton_OnHoldButtonDown;
        rotateLeftButton.OnHoldButtonUp += RotateLeftButton_OnHoldButtonUp;
    }

    private void RotateLeftButton_OnHoldButtonUp()
    {
        OnHoldLeftButton = false;
    }

    private void RotateLeftButton_OnHoldButtonDown()
    {
        OnHoldLeftButton = true;
    }

    private void RotateRightButton_OnHoldButtonUp()
    {
        OnHoldRightButton = false;
    }

    private void RotateRightButton_OnHoldButtonDown()
    {
        OnHoldRightButton = true;
    }

    private void Update()
    {
        if (OnHoldRightButton)
        {
            border.transform.Rotate(-Vector3.forward * Time.deltaTime * rotationSpeed);
        }
        if (OnHoldLeftButton)
        {
            border.transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }
    }
}
