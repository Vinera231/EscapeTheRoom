using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowWin : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
        CursorShower.Instance.Show();
    }
}
