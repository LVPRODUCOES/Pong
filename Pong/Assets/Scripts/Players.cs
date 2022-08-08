using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float SpeedPlayer;

    public bool player1;

    public float minY;

    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player1 == true)
        {
            MovePlayer1();
        }
        else
        {
            MovePlayer2();
        }
    }

    private void MovePlayer1()
    {
        transform.position =
            new Vector2(transform.position.x,
                Mathf.Clamp(transform.position.y, minY, maxY));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * SpeedPlayer * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * SpeedPlayer * Time.deltaTime);
        }
    }

    private void MovePlayer2()
    {
        transform.position =  new Vector2(transform.position.x,
                              Mathf.Clamp(transform.position.y, minY, maxY));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * SpeedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * SpeedPlayer * Time.deltaTime);
        }
    }
}
