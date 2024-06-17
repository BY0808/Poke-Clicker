using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    //상점에서 구매 가능한 정보
    [SerializeField] private ClickInput _clickInput;
    [SerializeField] private ClickerDeco _clickerDeco;
    [SerializeField] private Deco _deco;

    private void Start()
    {
        _clickInput = GetComponent<ClickInput>();
    }

}
