using TMPro;
using UnityEngine;

public class GraphemeBubble : MonoBehaviour
{
    [SerializeField]
    public string grapheme = "s";

    void Start()
    {
       GetComponentInChildren<TextMeshProUGUI>().text = grapheme;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
