using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickInput : MonoBehaviour
{
    public event Action<int> OnClickEvent;

    public int ClickCount=0;

    private void Start()
    {
        StartCoroutine(AutoClickCoroutine());
    }

    public void OnClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            ClickCount++;
            OnClickEvent?.Invoke(ClickCount);
            Debug.Log(ClickCount);
        }
    }

    IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            OnClickEvent?.Invoke(++ClickCount);
            Debug.Log("Auto : " + ClickCount);
        }
    }
}
