using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Waypoint[] waypoints;

    // Giúp lấy tọa độ waypoint bằng cách gọi nhanh flyPath[index]
    public Vector3 this[int index] => waypoints[index].transform.position;

    // Vẽ các đường nối màu xanh lá trên màn hình Scene để dễ thiết kế
    private void OnDrawGizmos()
    {
        if (waypoints == null) return;
        
        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i + 1].transform.position);
        }
    }
}