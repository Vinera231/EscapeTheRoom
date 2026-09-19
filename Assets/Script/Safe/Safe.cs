using UnityEngine;

public class Safe : MonoBehaviour
{
    [SerializeField] private string _password;
    [SerializeField] private ViewPasswordSafe _view;
    [SerializeField] private SafeOpen _safeOpen;

    private string _inputPassword;
    private bool _isOpen;

    public void PressEnter()
    {
       TryOpen();
    }

    public void AddNumber(int number)
    {
        if (_isOpen)
            return;

        _inputPassword += number.ToString();
        _view.ShowPassword(_password);
    }

    public void RemoveNumber()
    {
        if(_inputPassword.Length == 0) 
            return;

        _inputPassword = _inputPassword.Remove(_inputPassword.Length - 1);
        _view.ShowPassword(_inputPassword);
    }

    public void TryOpen()
    {
        if (_isOpen)
            return;

        if (_inputPassword == _password)
        {
            _isOpen = true;
            _inputPassword = "";
            _view.Correct();
            _safeOpen.PlaySafeOpen();
        }
        else
        {
            _inputPassword = "";
            _view.Incorrect();
        }
    }
}
