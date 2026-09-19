using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowWin : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

    private void OnTriggerEnter()
    {
        _winPanel.SetActive(true);
        SceneManager.LoadScene(0);
    }
}
