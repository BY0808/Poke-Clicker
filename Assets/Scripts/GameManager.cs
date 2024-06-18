using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI _clickCountText;
    [SerializeField] private TextMeshProUGUI _pointText;

    public int ClickCount = 0;
    private int _curClickCount = 0;
    public int Point = 100;

    [SerializeField] public int ChangeClickPerCount = 5;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        UpdateClickCountUI();
        AddPoint();
    }

    public void UpdatePerClick(TextMeshProUGUI text)
    {
        ChangeClickPerCount = int.Parse(text.text);
    }

    private void UpdateClickCountUI()
    {
        _clickCountText.text = ClickCount.ToString();
    }

    public void UpdatePoint()
    {
        _pointText.text = Point.ToString();
    }

    private void AddPoint()
    {
        if (ClickCount - _curClickCount >= 100)
        {
            Point += 10;
            _curClickCount = ClickCount;
        }
        UpdatePoint();
    }

    public void UsePoint(int point)
    {
        Point -= point;
        UpdatePoint();
    }
}
