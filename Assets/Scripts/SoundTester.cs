using UnityEngine;
using System.Collections;

public class SoundTester : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    void Update ()
    {
        foreach (var touch in Input.touches) {
            if (touch.phase == TouchPhase.Began) {
                _audioSource.Play();
                break;
            }
        }
    }

    void Reset()
    {
        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
        }
    }
}