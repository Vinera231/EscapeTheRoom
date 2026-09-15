using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private ButtonInformer _button;

    public void OnEnable() =>
        _button.Clicked += ExitGame;

    public void OnDisable() =>
        _button.Clicked -= ExitGame;

    private void ExitGame() =>    
       Application.Quit();  
}