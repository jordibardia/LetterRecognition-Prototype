using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private int health = 3;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var rayHit = Physics2D.GetRayIntersection(ray);

            if (rayHit.collider)
            {
                GameObject bubble = rayHit.collider.gameObject;
                string bubbleText = bubble.GetComponentInChildren<TextMeshProUGUI>().text;

                if (bubbleText != "s")
                    health -= 1;

                Destroy(rayHit.collider.gameObject);
            }
        }
    }
}
