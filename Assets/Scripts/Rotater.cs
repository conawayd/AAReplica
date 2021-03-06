using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime * PlayerPrefs.GetFloat("spinSpeed"));
    }
}
