using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;

    public Text text;

    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {
        text.text = PinCount.ToString();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("saveScore", PinCount);
    }

    public void LoadScore()
    {
        PinCount = PlayerPrefs.GetInt("saveScore");
    }
}
