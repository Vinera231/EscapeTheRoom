using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const KeyCode _pressPassword = KeyCode.Mouse0;
    private const KeyCode _pressList = KeyCode.Mouse1;

    public Action Opened;
    public Action Pressed;
    public Action Entered;
    public Action Taken;

    private void Update()
    {
        ReadPressPassword();
        ReadPressList();
    }
    
    private void ReadPressPassword()
    {
        if(Input.GetKeyDown(_pressPassword))
            Pressed?.Invoke();
    }
    private void ReadPressList()
    {
        if(Input.GetKeyDown(_pressList))
            Entered?.Invoke();
    }
}
