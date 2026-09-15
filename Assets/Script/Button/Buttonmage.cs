using System;
using UnityEngine;
using UnityEngine.UI;

public class Buttonmage : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _image;
  

    private void OnEnable() =>  
        _button.onClick.AddListener(onClick);   

    private void onClick() =>
      _image.SetActive(false); 
}