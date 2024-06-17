using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    //�������� ���� ������ ����
    [SerializeField] private ClickInput _clickInput;
    [SerializeField] private ClickerDeco _clickerDeco;
    [SerializeField] private Deco _deco;

    private void Start()
    {
        _clickInput = GetComponent<ClickInput>();
    }

}
