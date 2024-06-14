using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI _clickCountText;
    [SerializeField] private ClickInput _clickInput;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        UpdateClickCountUI();
    }

    private void UpdateClickCountUI()
    {
        _clickCountText.text = _clickInput.ClickCount.ToString();
    }
}
