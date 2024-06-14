using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickInput : MonoBehaviour
{
    public event Action<int> OnClickEvent;

    public int count=0;
    
    public void OnClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            count++;
            OnClickEvent?.Invoke(count);
            Debug.Log(count);
        }
    }
}
