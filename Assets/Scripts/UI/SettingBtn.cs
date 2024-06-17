using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBtn : PauseBtn
{
    [SerializeField] private GameObject _settingPanel;

    public void ButtonOnClick()
    {
        _settingPanel.SetActive(!_settingPanel.activeSelf);
    }

    public void QuitButton()
    {

    }
}
