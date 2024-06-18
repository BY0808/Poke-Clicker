using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{
    private int _curClickPerCount = 0;

    public void ButtonOnClickPause()
    {
        if (Time.timeScale == 1f)
        {
            _curClickPerCount = GameManager.Instance.ChangeClickPerCount;
            GameManager.Instance.ChangeClickPerCount = 0;
            Time.timeScale = 0f;
        }
        else
        {
            if (GameManager.Instance.ChangeClickPerCount > 0)
            {
                _curClickPerCount = GameManager.Instance.ChangeClickPerCount;
            }
            GameManager.Instance.ChangeClickPerCount = _curClickPerCount;
            Time.timeScale = 1f;
        }
    }
}
