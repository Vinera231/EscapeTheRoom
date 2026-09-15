using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject _textkey;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _textkey.SetActive(true);
        }
    }
   
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _textkey.SetActive(false);
        }
    }
}