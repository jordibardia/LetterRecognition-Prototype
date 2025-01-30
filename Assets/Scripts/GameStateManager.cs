using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    [SerializeField]
    public GameObject timer;

    [SerializeField]
    public GameObject GameOver;

    [SerializeField]
    public GameObject GameWin;

    void Start()
    {
        Time.timeScale = 1.0f;

        GameOver.SetActive(false);
        GameWin.SetActive(false);
    }

    void Update()
    {
        if (Mathf.FloorToInt(timer.GetComponent<Timer>().currTime) == 0)
        {
            GameWin.SetActive(true);
            Time.timeScale = 0.0f;
        }
        if (player.GetComponent<Health>().currHealth <= 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
