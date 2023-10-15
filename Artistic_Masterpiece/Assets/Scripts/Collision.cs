using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
         
        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;

        collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }
}

