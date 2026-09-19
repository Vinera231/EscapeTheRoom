using TMPro;
using UnityEngine;

public class Door : MonoBehaviour, IInteractableObject
{
    [SerializeField] private TMP_Text _hint;
    [SerializeField] private AnimationDoor _animationDoor;
    [SerializeField] private Key _key;

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
       // if (_key.HasKey == false)
           //return;

        if (Input.GetKeyUp(KeyCode.T))
        {
            _animationDoor.PlayAnimation();
            _key.gameObject.SetActive(true);
        }
    }

    public void ShowHint()
    {
        _hint.gameObject.SetActive(true);
    }
}
