using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class IntroSettings : MonoBehaviour
{
    public Slider slider_spinSpeed;
    public Slider slider_pinSpeed;
    public Dropdown dropdown_lives;
    public Dropdown dropdown_time;
    public InputField inputField_name;

    void Start()
    {
        PlayerPrefs.SetFloat("spinSpeed", 1f);
        PlayerPrefs.SetFloat("pinSpeed", 1f);
        PlayerPrefs.SetInt("lives", 1);
        PlayerPrefs.SetString("name", "");
        PlayerPrefs.SetFloat("time", 15f);
    }

    public void SetSpinSpeed()
    {
        PlayerPrefs.SetFloat("spinSpeed", slider_spinSpeed.value);
    }

    public void SetPinSpeed()
    {
        PlayerPrefs.SetFloat("pinSpeed", slider_pinSpeed.value);
    }

    public void SetLives()
    {
        if (dropdown_lives.value == 0)
        {
            PlayerPrefs.SetInt("lives", 1);
        }
        else if (dropdown_lives.value == 1)
        {
            PlayerPrefs.SetInt("lives", 2);
        }
        else
        {
            PlayerPrefs.SetInt("lives", 3);
        }
    }

    public void SetName()
    {
        PlayerPrefs.SetString("name", inputField_name.text);
    }

    public void SetTime()
    {
        int x = dropdown_time.value;

        switch(x)
        {
            case 0: 
                PlayerPrefs.SetFloat("time", 15f);
                break;

            case 1:
                PlayerPrefs.SetFloat("time", 30f);
                break;

            case 2:
                PlayerPrefs.SetFloat("time", 45f);
                break;

            default:
                PlayerPrefs.SetFloat("time", 15f);
                break;
        }
    }
}
