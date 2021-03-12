using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotater rotator; // 
    public PinSpawner spawner;
    public Text text_lives;
    public Text text_name;

    public Animator animator;

    void Start()
    {
        text_lives.text = PlayerPrefs.GetInt("lives").ToString();
        text_name.text = PlayerPrefs.GetString("name");
    }

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;

        if (PlayerPrefs.GetInt("lives") > 1)
        {
            PlayerPrefs.SetInt("lives", PlayerPrefs.GetInt("lives") - 1);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
