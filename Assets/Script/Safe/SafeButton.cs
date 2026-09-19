using System;
using UnityEngine;

public class SafeButton : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Safe _safe;
    [SerializeField] private int _number;
    [SerializeField] private bool _isEnter;


    private void OnEnable() =>
    _inputReader.Pressed += AnimationPress;


    private void OnDisable() =>
   _inputReader.Pressed -= AnimationPress;


    public void AnimationPress()
    {
        _animator.SetTrigger("Press");
        if (_isEnter)
        {
            _safe.PressEnter();
            return;
        }
            _safe.AddNumber(_number);
    }
}