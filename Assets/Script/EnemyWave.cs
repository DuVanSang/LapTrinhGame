using UnityEngine;

[System.Serializable]
public class EnemyWave
{
    public GameObject enemyPrefab;     // Kéo Prefab quái vật vào đây
    public int numberOfEnemy;          // Số lượng quái sinh ra
    public Vector3 formationOffset;    // Khoảng cách giữa các con quái (đội hình)
    public FlyPath flyPath;            // KÉO ĐƯỜNG BAY VÀO ĐÂY!
    public float speed;                // Tốc độ bay
    public float nextWaveDelay;        // Thời gian chờ đến đợt tiếp theo
}