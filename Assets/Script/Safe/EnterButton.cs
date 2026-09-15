using UnityEngine;

public class EnterButton : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Safe _safe;

    private bool _isEnter ;

    private void OnEnable() =>
   _inputReader.Pressed += EnterPress;


    private void OnDisable() =>
   _inputReader.Pressed -= EnterPress;

    private void EnterPress()
    {
       if(_isEnter == true)
        {
            _animator.SetTrigger("Press");
            _safe.PressEnter();
        }
    }
}