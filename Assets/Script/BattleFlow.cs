using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc thêm dòng này để dùng lệnh chuyển Scene

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject bgMusic;
    public GameObject gameWinUI;

    private void Start()
    {
        gameOverUI.SetActive(false); // Ẩn Game Over lúc mới chơi
        gameWinUI.SetActive(false);  // Ẩn Game Win lúc mới chơi
        playerHealth.onDead += OnGameOver; // Lắng nghe sự kiện Player chết
    }

    private void Update()
    {
        // Kiểm tra nếu quái chết hết thì gọi hàm chiến thắng
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true); // Bật Game Over
        bgMusic.SetActive(false);   // Tắt nhạc nền
    }

    // ĐÂY LÀ HÀM BẠN ĐANG BỊ THIẾU: Xử lý khi Game Win
    private void OnGameWin()
    {
        gameWinUI.SetActive(true); // Bật giao diện Win [cite: 1770]
        bgMusic.SetActive(false);  // Tắt nhạc nền [cite: 1771]
        playerHealth.gameObject.SetActive(false); // Ẩn máy bay Player đi [cite: 1772]
    }

    // Hàm này dành cho nút bấm "Return to Main Menu"
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}