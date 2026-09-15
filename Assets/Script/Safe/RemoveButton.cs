using UnityEngine;

public class RemoveButton : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Safe _safe;
    [SerializeField] private bool _isRemove;

    private void OnEnable() =>
  _inputReader.Pressed += AnimationPress;


    private void OnDisable() =>
   _inputReader.Pressed -= AnimationPress;

    private void AnimationPress()
    {
        _animator.SetTrigger("Press");
        if (_isRemove)
        {
            _safe.RemoveNumber();
            return;
        }
    }
}