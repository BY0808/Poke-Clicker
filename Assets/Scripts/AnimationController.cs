using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator _animator;
    protected ClickInput _clickInput;

    private static readonly int Click = Animator.StringToHash("OnClick");

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _clickInput = GetComponent<ClickInput>();
        _clickInput.OnClickEvent += OnClickAnimation;
    }

    private void OnClickAnimation(int count)
    {
        _animator.SetTrigger("OnClick");
    }
}
