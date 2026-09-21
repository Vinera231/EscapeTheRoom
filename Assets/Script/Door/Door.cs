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
        if (Input.GetKeyUp(KeyCode.T))
        {
            _animationDoor.PlayAnimation();
            _key.SetActive(false);
        }
    }

    public void ShowHint()
    {
        _hint.gameObject.SetActive(true);
    }
}
