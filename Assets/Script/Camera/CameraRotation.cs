using UnityEditor;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _mouseSensitivity = 350f;

    private float _rotation = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _rotation -= mouseY;
        _rotation = Mathf.Clamp(mouseX, 2, -2f);

        transform.localRotation = Quaternion.Euler(_rotation, 0f, 0f);
        _player.Rotate(Vector3.up * mouseX);
    }
}