using TMPro;
using UnityEngine;

public class MoveGraphemeBubble : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed = 5.0f;
    private float yUpperLimit = 6.0f;
    private float yLowerLimit = -6.0f;

    [SerializeField]
    private float sineFrequency = 2.0f;
    [SerializeField]
    private float sineAmplitude = 0.1f;
    private float startX;

    public bool moveUp = true;
    private float downVerticalSpeed = 8.0f;

    void Start()
    {
        startX = transform.position.x;
        yLowerLimit = GameObject.FindGameObjectWithTag("BubbleSpawnManager").GetComponent<BubbleSpawnManager>().spawnPositionY;
    }

    void Update()
    {
        if (this.transform.position.y >= yUpperLimit)
        {
            if (GetComponentInChildren<TextMeshProUGUI>().text == "s")
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                player.GetComponent<Health>().RemoveHeart();
            }

            Destroy(this.gameObject);
        }

        if (moveUp)
        {
            float newX = startX + Mathf.Sin(Time.time * sineFrequency) * sineAmplitude;
            float newY = transform.position.y + verticalSpeed * Time.deltaTime;

            transform.position = new Vector3(newX, newY, transform.position.z);
        }
        else
        {
            float newY = transform.position.y - downVerticalSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

            if (transform.position.y < yLowerLimit)
                moveUp = true;
        }
    }
}
