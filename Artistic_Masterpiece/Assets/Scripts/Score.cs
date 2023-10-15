using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public float playerScore = 0.0f;
    public float playerHealth = 3.0f;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        ColliderTag tag = collision.GetComponent<ColliderTag>();
        if (tag != null)
        {
            if (tag.type == ColliderTag.Type.SCORE_UP)
            {
                playerScore += 1;
                scoreText.text = "SCORE: " + playerScore.ToString();

            }

            else if (tag.type == ColliderTag.Type.HEALTH_DOWN)
            {
                playerHealth -= 1.0f;
                healthText.text = "HEALTH: " + playerHealth.ToString();

            }
        }
    }

}


