using UnityEngine;

public class CursorShower : MonoBehaviour
{
    private bool _isOn;

    public static CursorShower Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            return;
        }

        if (_isOn)
            Show();
        else
            Hide();
    }

    public void Show()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Hide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
