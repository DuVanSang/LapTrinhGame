using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Lấy vị trí chuột và chuyển đổi sang tọa độ thế giới game
        var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPoint.z = 0; // Đảm bảo z = 0 vì là game 2D
        
        // Gán vị trí tàu bằng vị trí chuột
        transform.position = worldPoint;
    }
}