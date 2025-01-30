using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int maxHealth = 3;
    public int currHealth;

    public List<GameObject> hearts;

    private void Start()
    {
        currHealth = maxHealth;

        for (int i = 0; i < hearts.Count; i++)
            hearts[i].SetActive(true);
    }

    public void RemoveHeart()
    {
        currHealth -= 1;
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i >= currHealth)
                hearts[i].SetActive(false);
        }
    }
}
