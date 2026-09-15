using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const KeyCode _openNote = KeyCode.E;
    private const KeyCode _takeKey = KeyCode.Q;
    private const KeyCode _openDoor = KeyCode.T;
    private const KeyCode _pressPassword = KeyCode.Mouse0;

    public Action Opened;
    public Action Pressed;
    public Action Entered;
    public Action Taken;

    private void Update()
    {
        ReadOpenNote();
        ReadTakeKey();
        ReadOpenDoor();
        ReadPressPassword();
    }

    private void ReadOpenNote()
    {
        if(Input.GetKeyDown(_openNote))
           Opened?.Invoke();
    }
   
    private void ReadTakeKey()
    {
        if(Input.GetKeyDown(_takeKey))
           Taken?.Invoke();
    }
  
    private void ReadOpenDoor()
    {
        if(Input.GetKeyDown(_openDoor))
            Entered?.Invoke();
    }
    
    private void ReadPressPassword()
    {
        if(Input.GetKeyDown(_pressPassword))
            Pressed?.Invoke();
    }
}
