using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Store : MonoBehaviour
{
    //�������� ���� ������ ����
    [SerializeField] private ClickInput _clickInput;
    [SerializeField] private ClickerDeco _clickerDeco;
    [SerializeField] private Deco _deco;

    //������ ����
    private int _clickInputPoint = 100;
    [SerializeField] private TextMeshProUGUI _clickPointText;

    public void UpgradePerClick()
    {
        //����Ʈ ���
        if (GameManager.Instance.Point >= _clickInputPoint)
        {
            //����Ʈ ������Ʈ
            GameManager.Instance.Point -= int.Parse(_clickPointText.text);
            _clickPointText.text = (int.Parse(_clickPointText.text) * 2).ToString();
            GameManager.Instance.UpdatePoint();

            //���� ���� ������Ʈ
            _clickInput.ChangeClickPerCount *= 2;
        }
        else
        {
            Debug.Log("����Ʈ�� �����մϴ�.");
        }
    }

    public void ChangeClicker()
    {

    }
}
