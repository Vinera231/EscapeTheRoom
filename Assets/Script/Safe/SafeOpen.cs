using UnityEngine;

public class SafeOpen : MonoBehaviour
{
    private readonly int s_animationSafeOpen = Animator.StringToHash("IsOpen");

    [SerializeField] private Animator _animator;
    public void PlaySafeOpen()
    {
        _animator.SetBool( s_animationSafeOpen,true);
    }

    public void PlayIdleOpen() =>
        _animator.SetBool(s_animationSafeOpen,false);
}