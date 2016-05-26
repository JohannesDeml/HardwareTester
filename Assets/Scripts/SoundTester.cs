using UnityEngine;
using System.Collections;

public class SoundTester : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    void Update ()
    {
        foreach (var touch in Input.touches) {
            if (touch.phase == TouchPhase.Began) {
                audioSource.Play();
                break;
            }
        }
    }

    void Reset()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
}