using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float SpeedBall;

    public float SpeedAdd;

    public float SpeedBallMax;

    public float directionRandomX;

    public float directionRandomY;
    
    public Rigidbody2D oRigidybody2D;

    public AudioSource somBall;

    
    // Start is called before the first frame update
    void Start()
    {
        MoveBall(); 
    }

    // Update is called once per frame
    void Update()
    {       
      if(SpeedBall < SpeedBallMax)
      {
        SpeedBall += SpeedAdd;
      }
    }

    private void MoveBall()
    {
      oRigidybody2D.velocity = new Vector2(SpeedBall, SpeedBall);
    }

      void OnCollisionEnter2D(Collision2D collisionInfo)
    {
      somBall.Play();
 
      oRigidybody2D.velocity += new Vector2(directionRandomX, directionRandomY);
    
    
    }
    
  


}
