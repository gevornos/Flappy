using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject loseWindow;

    public void Start()
    {
        instance = this;
    }


    public void Lose()
    {
        loseWindow.SetActive(true);
        Time.timeScale = 0;
    }

        public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

        public void LoadScene(int sceneNumber)
        {
            SceneManager.LoadScene(sceneNumber);
            Time.timeScale = 1;
        }

}
