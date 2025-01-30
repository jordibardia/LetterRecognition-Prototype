using UnityEngine;

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
}
