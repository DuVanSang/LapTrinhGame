using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyWave[] enemyWaves;
    private int currentWave;

    void Start()
    {
        SpawnEnemyWave();
    }

    private void SpawnEnemyWave()
    {
        // Kiểm tra xem còn đợt quái nào chưa ra không
        if (currentWave < enemyWaves.Length)
        {
            var waveInfo = enemyWaves[currentWave];
            var startPosition = waveInfo.flyPath[0]; // Bắt đầu ở điểm waypoint 0

            // Sinh ra số lượng quái vật theo thiết lập
            for (int i = 0; i < waveInfo.numberOfEnemy; i++)
            {
                var enemy = Instantiate(waveInfo.enemyPrefab, startPosition, Quaternion.identity);
                
                // ĐÂY LÀ LÚC TA TRUYỀN ĐƯỜNG BAY CHO QUÁI VẬT MÀ KHÔNG CẦN KÉO THẢ:
                var agent = enemy.GetComponent<FlyPathAgent>();
                agent.flyPath = waveInfo.flyPath;
                agent.flySpeed = waveInfo.speed;
                
                startPosition += waveInfo.formationOffset;
            }

            currentWave++;
            // Chờ một thời gian rồi gọi lại hàm này để sinh đợt tiếp theo
            Invoke(nameof(SpawnEnemyWave), waveInfo.nextWaveDelay);
        }
    }
}