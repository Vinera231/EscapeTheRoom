using UnityEngine;

public class ZonaOpenDoor : MonoBehaviour
{
    [SerializeField] private GameObject _textDoor;
    [SerializeField] private Player _player;
    [SerializeField] private AnimationDoor _door;
    [SerializeField] private InputReader _reader;

    private void OnEnable() =>
        _reader.Entered += OpenDoor;

    private void OnDisable() =>
        _reader.Entered -= OpenDoor;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Player player))
        {
            _player = player;
            _textDoor.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _player = null;
            _textDoor.SetActive(false);
        }
    }

    private void OpenDoor()
    {
        if (_player == null)
            return;

        if (!_player.HasKey)
            return;

        if(_player.HasKey)
        _door.PlayAnim();
       
        _player.UsedKey();
        _textDoor.SetActive(false);
    }
}