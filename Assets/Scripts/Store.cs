using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Store : MonoBehaviour
{
    [Header("ChangePerClick")]
    [SerializeField] private ClickInput _clickInput;
    [SerializeField] private TextMeshProUGUI _clickPointText;
    [SerializeField] private TextMeshProUGUI _clickIcon;
    private int _curPerClick;

    [Header("ChangeClickerImage")]
    [SerializeField] private GameObject _clickerDeco;
    [SerializeField] private TextMeshProUGUI _clickerPrice;
    private SpriteRenderer _curSprite;
    private int _currentIndex = 0;
    [SerializeField] private Sprite[] _clickerSprites;
    [SerializeField] private Image _clickerImage;

    [Header("ChangeBackground")]
    [SerializeField] private GameObject _backgroundDeco;
    [SerializeField] private TextMeshProUGUI _backgroundPrice;
    private SpriteRenderer _curBackground;
    private int _curBackgroundIndex = 0;
    [SerializeField] private Sprite[] _backgroundSprites;
    [SerializeField] private Image _backgroundImage;

    void Start()
    {
        _curPerClick = GameManager.Instance.ChangeClickPerCount;
        _curSprite = _clickerDeco.GetComponent<SpriteRenderer>();
        _curBackground = _backgroundDeco.GetComponent<SpriteRenderer>();
    }

    public void UpgradePerClick()
    {
        //����Ʈ ���
        if (GameManager.Instance.Point >= int.Parse(_clickPointText.text))
        {
            UpdatePointText(_clickPointText);
            _clickPointText.text = (int.Parse(_clickPointText.text) * 2).ToString();
            _clickIcon.text = (int.Parse(_clickIcon.text) * 2).ToString();

            //���� ���� ������Ʈ
            _curPerClick *= 2;
            GameManager.Instance.UpdatePerClick(_clickIcon);
        }
        else
        {
            Debug.Log("����Ʈ�� �����մϴ�.");
        }
    }

    public void ChangeClicker()
    {
        ChangeImage(ref _currentIndex, _clickerSprites, _curSprite, _clickerImage, _clickerPrice);
    }

    public void ChangeBackground()
    {
        ChangeImage(ref _curBackgroundIndex, _backgroundSprites, _curBackground, _backgroundImage, _backgroundPrice);
    }

    public void ChangeImage(ref int currentIndex, Sprite[] sprites, SpriteRenderer spriteRenderer, Image image, TextMeshProUGUI text)
    {
        if (GameManager.Instance.Point >= int.Parse(text.text))
        {
            if (currentIndex < sprites.Length)
            {
                UpdatePointText(text);

                //���� ���� ������Ʈ
                currentIndex = (currentIndex + 1) % sprites.Length;
                spriteRenderer.sprite = sprites[currentIndex];
                image.sprite = sprites[currentIndex+1];
            }
            else
            {
                Debug.Log("�ִ� ���׷��̵� �Դϴ�.");
            }
        }
        else
        {
            Debug.Log("����Ʈ�� �����մϴ�.");
        }
    }

    private void UpdatePointText(TextMeshProUGUI text)
    {
        GameManager.Instance.Point -= int.Parse(text.text);
        GameManager.Instance.UpdatePoint();
    }
}
