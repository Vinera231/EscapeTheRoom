using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImage : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _image;
    [SerializeField] private InputReader _inputReader;

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
        _inputReader.Entered += Hide;

    }

    private void OnDisable() =>
    _inputReader.Entered -= Hide;
    public void OnClick()
    {
        _image.SetActive(false);
        PauseSwitcher.Instance.PauseGame();
        CursorShower.Instance.Show();
    }

    private void Hide()
    {
        _image.SetActive(false);
        PauseSwitcher.Instance.PlayGame();
        CursorShower.Instance.Hide();
    }
}