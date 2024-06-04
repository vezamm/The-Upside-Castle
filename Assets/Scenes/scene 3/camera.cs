using UnityEngine;

public class camera : MonoBehaviour
{
    public float targetHeight = 5.0f; // Set your desired height

    void Start()
    {
        Camera.main.aspect = 16f / 9f; // Set your desired aspect ratio

        // Calculate the orthographic size based on the target height and aspect ratio
        float orthographicSize = targetHeight / 2f;
        Camera.main.orthographicSize = orthographicSize;
    }
}

