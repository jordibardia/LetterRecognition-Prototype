using TMPro;
using Unity.Android.Gradle;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start time in seconds
    [SerializeField]
    public float startTime = 30.0f;
    public float currTime;

    private void Start()
    {
        currTime = startTime;
    }

    void Update()
    {
        currTime -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(currTime % 60);

        var textComponent = GetComponentInChildren<TextMeshProUGUI>();
        textComponent.text = $"Time Left: {seconds}";
    }
}
