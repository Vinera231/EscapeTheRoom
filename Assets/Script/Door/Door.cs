using TMPro;
using UnityEngine;

public class Door : MonoBehaviour, IInteractableObject
{
    [SerializeField] private TMP_Text _hint;
    [SerializeField] private AnimationDoor _animationDoor;
    [SerializeField] private GameObject _key;

    private void Awake()
    {
        HideHint();
    }

    public void HideHint()
    {
        _hint.gameObject.SetActive(false);
    }

    public void Interact()
    {
            SfxPlayer.Instance.PlayDoor();
        if (Input.GetKeyUp(KeyCode.E))
        {
            _animationDoor.PlayAnimation();
            PlaySound();
            _key.SetActive(false);
        }
    }

    private void PlaySound() =>
        SfxPlayer.Instance.PlayDoor();

    public void ShowHint()
    {
        _hint.gameObject.SetActive(true);
    }
}
