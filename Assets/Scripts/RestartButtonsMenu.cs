using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartButtonsMenu : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _nextlevel;

    private void Start()
    {
        _restartButton.onClick.AddListener(Restart);
        _mainMenuButton.onClick.AddListener(MainMenu);
        _nextlevel.onClick.AddListener(NextLevel);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
    private void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
