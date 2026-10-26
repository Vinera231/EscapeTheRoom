using UnityEngine;

public class SfxPlayer: MonoBehaviour
{
    [SerializeField] private AudioSource _sfx;
    [SerializeField] private AudioClip _screamSound;
    public static SfxPlayer Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
            Instance = this;
    }

    public void PlayScream( ) =>
        _sfx.PlayOneShot(_screamSound);
    
    public void PlayStop() =>
        _sfx.Stop();

    public void PlayOneShoot(AudioClip audioClip)=>
        _sfx.PlayOneShot(audioClip);
}