using UnityEngine;
using System.Collections;

public class TouchTester : MonoBehaviour
{
    [Range(0f, 1f), SerializeField] private float _touchSizeWidthPercentage = 0.33f;
    public Texture2D Texture;

    void Update ()
    {
        if (Input.touches.Length > 0) {
            transform.localScale = Vector3.one * 2.0f;
        } else {
            transform.localScale = Vector3.one;
        }
    }
    
    void OnGUI ()
    {
        var size = Screen.width * _touchSizeWidthPercentage;
        foreach (var touch in Input.touches) {
            GUI.DrawTexture (new Rect (touch.position.x - size / 2, Screen.height - touch.position.y - size / 2, size, size), Texture);
        }
    }
}