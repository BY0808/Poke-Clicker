using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreBtn : PauseBtn
{
    [SerializeField] private GameObject _storePanel;
    
    public void ButtonOnClick()
    {
        _storePanel.SetActive(!_storePanel.activeSelf);
    }
}
