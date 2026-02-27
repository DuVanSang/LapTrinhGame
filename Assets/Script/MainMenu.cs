using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("SpaceShooter");
    }
}