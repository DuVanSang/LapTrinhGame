using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed;
    private int nextIndex = 1;

    void Start()
    {
        // Vừa xuất hiện là tự động nhảy đến điểm Waypoint đầu tiên (số 0)
        transform.position = flyPath[0];
    }

    void Update()
    {
        if (flyPath == null) return;
        
        // Bay hết đường rồi thì dừng lại
        if (nextIndex >= flyPath.waypoints.Length) return;

        // Nếu chưa tới điểm Waypoint tiếp theo thì tiếp tục bay tới đó
        if (transform.position != flyPath[nextIndex])
        {
            FlyToNextWaypoint();
        }
        else
        {
            // Tới nơi rồi thì nhắm mục tiêu sang điểm kế tiếp
            nextIndex++;
        }
    }

    private void FlyToNextWaypoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime);
    }
}