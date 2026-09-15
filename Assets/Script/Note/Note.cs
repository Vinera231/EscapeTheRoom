using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private GameObject _textNote;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player))      
            _textNote.SetActive(true);       
    }
}