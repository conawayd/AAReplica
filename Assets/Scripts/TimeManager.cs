using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;
    public GameObject gameManager;

    //float timelimit = 15f;
    float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        float timelimit = PlayerPrefs.GetFloat("time");

        timeRemaining = timelimit;

        timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "game over";
            gameManager.GetComponent<GameManager>().EndGame();
        }
    }

    public void SaveTime()
    {
        PlayerPrefs.SetFloat("saveTime", timeRemaining);
    }

    public void LoadTime()
    {
        timeRemaining = PlayerPrefs.GetFloat("saveTime");
    }
}