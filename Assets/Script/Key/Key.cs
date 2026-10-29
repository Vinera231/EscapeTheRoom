using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Key : MonoBehaviour, IInteractableObject
{
    [SerializeField] private TMP_Text _key;
    [SerializeField] private GameObject _keyPrefab;

    public void HideHint()
    {
        _key.gameObject.SetActive(false);
    }

    public void Interact()
    {
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            _keyPrefab.SetActive(true);
            PlaySound();
        }
    }

    private void PlaySound() =>
         SfxPlayer.Instance.PlayKey();

    public void ShowHint()
    {
        _key.gameObject.SetActive(true);
    }
}