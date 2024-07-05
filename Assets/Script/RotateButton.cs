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


    private Vector3 rotationValue = new Vector3 (0, 0, 1f);

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
        HandleRightRotation();
        HandleLeftRotation();
    }

    private void HandleRightRotation()
    {
        if (OnHoldRightButton)
        {
            border.transform.Rotate(rotationValue * Time.deltaTime * rotationSpeed);
        }
    }

    private void HandleLeftRotation()
    {
        if (OnHoldLeftButton)
        {
            border.transform.Rotate(-rotationValue * Time.deltaTime * rotationSpeed);
        }
    }
}
