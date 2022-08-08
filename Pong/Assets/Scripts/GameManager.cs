using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ScorePlayer1;

    public int ScorePlayer2;

    public Text textScore;

    public AudioSource soundGoal;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
         
        ScorePlayer1 = 0;
        ScorePlayer2 = 0;
        textScore.text = ScorePlayer1 + " X " + ScorePlayer2;
    }

    // Update is called once per frame
    void Update()
    {
       
       if(Input.GetKeyDown(KeyCode.R))
       {
         ResetGame();
       }
       
       if(Input.GetKeyDown(KeyCode.Escape))
       {
          CloseGame();
       }
    }

    public void ScoreUpPlayer1()
    {
        ScorePlayer1 += 1;
        UpdateTextScore();
    }

    public void ScoreUpPlayer2()
    {
        ScorePlayer2 += 1;
        UpdateTextScore();
    }

    public void UpdateTextScore()
    {
        textScore.text = ScorePlayer1 + " X " + ScorePlayer2;
      soundGoal.Play();
    
    }
   
     private void ResetGame()
   {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

private void  CloseGame()
{
    Application.Quit();
    Debug.Log("Exit the game");
}

}
