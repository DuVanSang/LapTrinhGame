using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Tốc độ bay của đạn
    public float flySpeed = 5f; 

    void Update()
    {
        // Lấy vị trí hiện tại
        var newPosition = transform.position;
        
        // Thay đổi tọa độ Y để đạn bay lên trên theo thời gian
        newPosition.y += Time.deltaTime * flySpeed;
        
        // Cập nhật lại vị trí mới cho đạn
        transform.position = newPosition;
    }
}