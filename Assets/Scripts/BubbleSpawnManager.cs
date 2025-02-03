using System.Collections;
using UnityEngine;
using TMPro;

public class BubbleSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bubble;

    [SerializeField]
    public float spawnPositionY = -6.0f;

    private bool spawnBubbles = true;
    private float currWait = 1.5f;
    private string[] possibleCharacters = { "s", "*", "!", "£" };

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        Vector2 spawnPos = Vector2.zero;

        while (spawnBubbles == true)
        {
            if (Time.time > 15.0f)
            {
                currWait = 0.7f;
            }
            else if (Time.time > 10.0f)
            {
                currWait = 0.9f;
            }
            else if (Time.time > 5.0f)
            {
                currWait = 1.0f;
            }

            yield return new WaitForSeconds(currWait);

            spawnPos.x = Random.Range(-7.5f, 7.5f);
            spawnPos.y = spawnPositionY;

            System.Random charSelector = new System.Random();
            int charInd = charSelector.Next(0, possibleCharacters.Length);

            var textComponent = bubble.GetComponentInChildren<TextMeshProUGUI>();
            textComponent.text = possibleCharacters[charInd];

            Instantiate(bubble, spawnPos, Quaternion.identity);
        }
    }
}
