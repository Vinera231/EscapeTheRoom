using TMPro;
using UnityEngine;

public class Key : MonoBehaviour, IInteractableObject
{
    [SerializeField] private TMP_Text _key;
    [SerializeField] private GameObject _keyPrefab;

    public bool _hasKey;
    public bool HasKey => _hasKey;

    public void HideHint()
    {
        _hasKey = false;
        _key.gameObject.SetActive(false);
    }

    public void Interact()
    {
        _hasKey = true;
        _keyPrefab.SetActive(true);
    }

    public void ShowHint()
    {
        _hasKey = true;
        _key.gameObject.SetActive(true);
    }
}