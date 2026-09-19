using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowWin : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private int _loadTime = 3;

    private void OnTriggerEnter()
    {
        _winPanel.SetActive(true);
        PauseSwitcher.Instance.PauseGame();
        StartCoroutine(Menu());
    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(_loadTime);
        SceneManager.LoadScene(0);
    }
}
