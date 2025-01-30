using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    [SerializeField]
    public GameObject GameOver;

    void Start()
    {
        GameOver.SetActive(false);
    }

    void Update()
    {
        if (player.GetComponent<Health>().currHealth <= 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }
}
