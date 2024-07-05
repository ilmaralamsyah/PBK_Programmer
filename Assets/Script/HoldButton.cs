using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    //private bool onHoldButton;

    public event Action OnHoldButtonDown;
    public event Action OnHoldButtonUp;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnHoldButtonDown?.Invoke();
        Debug.Log("hold");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        OnHoldButtonUp?.Invoke();
        Debug.Log("NotHold");
    }

    /*public bool OnHoldButton()
    {
        return onHoldButton;
    }*/
}
