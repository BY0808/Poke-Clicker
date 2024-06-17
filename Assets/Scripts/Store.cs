using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Store : MonoBehaviour
{
    //상점에서 구매 가능한 정보
    [SerializeField] private ClickInput _clickInput;
    [SerializeField] private ClickerDeco _clickerDeco;
    [SerializeField] private Deco _deco;

    //수정할 정보
    private int _clickInputPoint = 100;
    [SerializeField] private TextMeshProUGUI _clickPointText;

    public void UpgradePerClick()
    {
        //포인트 사용
        if (GameManager.Instance.Point >= _clickInputPoint)
        {
            //포인트 업데이트
            GameManager.Instance.Point -= int.Parse(_clickPointText.text);
            _clickPointText.text = (int.Parse(_clickPointText.text) * 2).ToString();
            GameManager.Instance.UpdatePoint();

            //구매 내용 업데이트
            _clickInput.ChangeClickPerCount *= 2;
        }
        else
        {
            Debug.Log("포인트가 부족합니다.");
        }
    }

    public void ChangeClicker()
    {

    }
}
