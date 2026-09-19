using UnityEditor;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _player;

    [Header("Settings")]
    [SerializeField] private float _mouseSensitivity = 350f;

    [Header("Pitch Limits")]
    [SerializeField] private float _minPitch = -80f;
    [SerializeField] private float _maxPitch = 80f;

    private float _pitch = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;     

        _pitch -= mouseY;
        _pitch = Mathf.Clamp(_pitch, _minPitch, _maxPitch); 
        transform.localRotation = Quaternion.Euler(_pitch, 0f, 0f); 
        _player.Rotate(Vector3.up * mouseX);
    }
}