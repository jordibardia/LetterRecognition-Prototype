using TMPro;
using UnityEngine;

public class MoveGraphemeBubble : MonoBehaviour
{
    [SerializeField]
    private float verticalSpeed = 5.0f;
    private float yLimit = 6.0f;
    
    [SerializeField]
    private float sineFrequency = 2.0f;
    [SerializeField]
    private float sineAmplitude = 0.1f;
    private float startX;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        if (this.transform.position.y >= yLimit)
        {
            if (GetComponentInChildren<TextMeshProUGUI>().text == "s")
            {
                GameObject player = GameObject.FindGameObjectWithTag("Player");
                player.GetComponent<Health>().RemoveHeart();
            }

            Destroy(this.gameObject);
        }

        float newX = startX + Mathf.Sin(Time.time * sineFrequency) * sineAmplitude;
        float newY = transform.position.y + verticalSpeed * Time.deltaTime;

        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
