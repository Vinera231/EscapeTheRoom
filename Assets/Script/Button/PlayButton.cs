using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private ButtonInformer _button;

    public void OnEnable() =>
        _button.Clicked += PlayGame;

    public void OnDisable() =>
        _button.Clicked -= PlayGame;

    private void PlayGame() =>
        SceneManager.LoadScene(1);
}
