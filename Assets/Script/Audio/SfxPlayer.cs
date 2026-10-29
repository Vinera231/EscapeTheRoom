using UnityEngine;

public class SfxPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _sfx;
    [SerializeField] private AudioClip _screamSound;
    [SerializeField] private AudioClip _keySound;
    [SerializeField] private AudioClip _letterSound;
    [SerializeField] private AudioClip _doorSound;
    public static SfxPlayer Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void PlayScream() =>
        _sfx.PlayOneShot(_screamSound);

    public void PlayLetter() =>
        _sfx.PlayOneShot(_letterSound);
   
    public void PlayDoor() =>
        _sfx.PlayOneShot(_doorSound);
   
    public void PlayKey() =>
        _sfx.PlayOneShot(_keySound);

    public void PlayStop() =>
        _sfx.Stop();

    public void PlayOneShoot(AudioClip audioClip) =>
        _sfx.PlayOneShot(audioClip);
}