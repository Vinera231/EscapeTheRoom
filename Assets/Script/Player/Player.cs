using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _delay = 0.2f;
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private GameObject _letter;
    [SerializeField] private InputReader _reder;
    [SerializeField]  private  List<AudioClip> _groundClips = new();
    
    private float _moveX, _moveZ;
    private float _currentWalkTime;  

    private bool _isWalking;
    private void Start() =>
     CursorShower.Instance.Hide();

    private void OnEnable()
    {
        _reder.Opened += TakeNote;
    }

    private void OnDisable()
    {
        _reder.Opened -= TakeNote;
    }

    private void Update()
    {
        _moveX = Input.GetAxis("Horizontal");
        _moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * _moveX + transform.forward * _moveZ;
        move.Normalize();

        _controller.Move(_speed * Time.deltaTime * move);
        PlayWalkSound(move);
    }

    private void PlayWalkSound(Vector3 move)
    {     
        if(move.sqrMagnitude < 0000.1f)
        {
            _currentWalkTime = 0f;
            SfxPlayer.Instance.PlayStop();
            return;
        }


        if(_currentWalkTime <= 0f)
        {
            if (_groundClips.Count > 0)
                SfxPlayer.Instance.PlayOneShoot(_groundClips.Last());                       
            
            _currentWalkTime = _delay;       
        }

        _currentWalkTime -= Time.deltaTime;
    }

    public void TakeNote()
    {
        _letter.SetActive(true);
        CursorShower.Instance.Show();
        PauseSwitcher.Instance.PauseGame();
    }
}