using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    [SerializeField] private Vector3 _velocity;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private GameObject _letter;
    [SerializeField] private InputReader _reder;

    private float _moveX, _moveZ;

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
    }

    public void TakeNote() =>
        _letter.SetActive(true);
}