using System.Collections;
using UnityEngine;
using TMPro;

public class BubbleSpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bubble;

    private bool spawnBubbles = true;
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
            yield return new WaitForSeconds(1.0f);

            spawnPos.x = Random.Range(-7.5f, 7.5f);
            spawnPos.y = -6.0f;

            System.Random charSelector = new System.Random();
            int charInd = charSelector.Next(0, possibleCharacters.Length);

            var textComponent = bubble.GetComponentInChildren<TextMeshProUGUI>();
            textComponent.text = possibleCharacters[charInd];

            Instantiate(bubble, spawnPos, Quaternion.identity);
        }
    }
}
