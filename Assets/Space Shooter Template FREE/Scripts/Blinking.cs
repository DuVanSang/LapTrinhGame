using UnityEngine;
using System.Collections;

public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Làm lửa tắt/bật liên tục tạo hiệu ứng nhấp nháy
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}