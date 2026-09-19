using UnityEngine;

public class AnimationDoor : MonoBehaviour
{
    private readonly int s_animationDoor = Animator.StringToHash("IsOpen");

    [SerializeField] private Animator _animator;

    public void PlayAnimation()
    {
        _animator.SetBool(s_animationDoor, true);
        Debug.Log(nameof(PlayAnimation));
    }
}