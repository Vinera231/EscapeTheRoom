using TMPro;
using UnityEngine;

public class Note : MonoBehaviour, IInteractableObject
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private GameObject _textNote;

    public void HideHint() =>
        _text.gameObject.SetActive(false);

    public void ShowHint() =>
         _text.gameObject.SetActive(true);

    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _textNote.SetActive(true);
            PlaySound();
        }
    }

    private void PlaySound() =>
    SfxPlayer.Instance.PlayLetter();
}