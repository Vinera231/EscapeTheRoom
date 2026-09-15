using TMPro;
using UnityEngine;

public class ViewPasswordSafe : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _correct;
    [SerializeField] private GameObject _error;

    public void ShowPassword(string password)=>
        _text.text = password;

    public void Correct()
    {
        _correct.SetActive(true);
        _error.SetActive(false);
        _text.enabled = false;
    }

    public void Incorrect()
    {
        _correct.SetActive(false);
        _error.SetActive(true);
        _text.enabled = false;
    }
}