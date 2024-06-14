using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickInput : MonoBehaviour
{
    public event Action<int> OnClickEvent;

    public int ChangeClickPerCount = 1;

    private void Start()
    {
        StartCoroutine(AutoClickCoroutine());
    }

    public void OnClickInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            GameManager.Instance.ClickCount += ChangeClickPerCount;
            OnClickEvent?.Invoke(GameManager.Instance.ClickCount);
            Debug.Log(GameManager.Instance.ClickCount);
        }
    }

    IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            OnClickEvent?.Invoke(++GameManager.Instance.ClickCount);
            Debug.Log("Auto : " + GameManager.Instance.ClickCount);
        }
    }
}
