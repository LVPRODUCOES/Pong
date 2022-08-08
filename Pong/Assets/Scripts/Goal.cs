using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool GoalPlayer1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (GoalPlayer1 == true)
        {
            FindObjectOfType<GameManager>().ScoreUpPlayer2();
            other.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().ScoreUpPlayer1();
            other.gameObject.transform.position = Vector2.zero;
        }
    }
}
