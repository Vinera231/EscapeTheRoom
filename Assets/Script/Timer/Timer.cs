using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _time;
    [SerializeField] private GameObject _scrimer;
    [SerializeField] private float _allTimes;
    [SerializeField] private int _loadTime = 2;

    private float _startTime;

    private void Start()
    {
        _startTime = Time.time;
        _scrimer.SetActive(false);
    }


    private void Update()
    {
        float currentTimes = _allTimes - Time.time;

        currentTimes = Mathf.Max(0, _allTimes - (Time.time - _startTime));

        int minutes = Mathf.FloorToInt(currentTimes / 60);
        int seconds = Mathf.FloorToInt(currentTimes % 60);

        _time.text = $"{minutes:00}:{seconds:00}";

        if (currentTimes == 0)
        {
            SfxPlayer.Instance.PlayScream();
            _scrimer.SetActive(true);

            StartCoroutine(LoadMenu());
        }
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(_loadTime);
        SceneManager.LoadScene(0);
    }
}