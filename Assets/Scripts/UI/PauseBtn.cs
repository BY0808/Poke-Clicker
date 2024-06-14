using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    [SerializeField] private ClickInput _clickInput;

    private int _curClickPerCount = 0;

    public void ButtonOnClickPause()
    {
        if (Time.timeScale == 1f)
        {
            _curClickPerCount = _clickInput.ChangeClickPerCount;
            _clickInput.ChangeClickPerCount = 0;
            Time.timeScale = 0f;
        }
        else
        {
            _clickInput.ChangeClickPerCount = _curClickPerCount;
            Time.timeScale = 1f;
        }
    }
}
