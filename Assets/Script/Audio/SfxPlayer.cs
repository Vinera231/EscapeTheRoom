using UnityEngine;

public class SfxPlayer: MonoBehaviour
{
    public static SfxPlayer Instance { get; private set; }
    [SerializeField] private AudioSource _sfx;
    [SerializeField] private AudioClip _screamSound;

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
}