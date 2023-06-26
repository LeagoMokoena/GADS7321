//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Computer : MonoBehaviour
//{
//    public float moveSpeed = 8.0f;
//    public float topBounds = 8.3f;
//    public float bottomBounds = -8.3f;
//    private GameObject ball;
//    private Vector2 ballPos;
//    public Vector2 startingPosition = new Vector2(13.0f, 0.0f);

//    // Update is called once per frame
//    void Update()
//    {
//        Move();
//    }

//    void Start()
//    {
//        transform.localPosition = (Vector3)startingPosition;
//    }

//    void Move()
//    {
//        if (!ball)
//            ball = GameObject.FindGameObjectWithTag("ball");

//        if (ball.GetComponent<tennisMove>().ballDirection == Vector2.Right)
//            {
//            ballPos = ball.transform.localPosition;

//            }
//        if(transform.localPosition.y > bottomBounds && ballPos.y < transform.localPosition.y)
//        {
//            transform.localPosition += new Vector3(0, -moveSpeed * Time.deltaTime, 0);

//        }

//        if (transform.localPosition.y < topBounds && ballPos.y > transform.localPosition.y)
//        {
//            transform.localPosition += new Vector3(0, -moveSpeed * Time.deltaTime, 0);

//        }

//    }

//}

using UnityEngine;
using System.Collections;

public class Computer : MonoBehaviour
{

    Transform Ball;
    Transform Ai;

    void Update()
    {
        //
        Ball = GameObject.FindGameObjectWithTag("Ball").transform;
        Ai = GameObject.FindGameObjectWithTag("Ai").transform;

        if (Ball.position.y > 0)
        {
            Debug.Log("Ball Pos " + Ball.position.y);
            Ai.position = new Vector3(Ai.position.x, Ball.position.y - 5, Ai.position.z);
        }
        else if (Ball.position.y < 0)
        {
            Debug.Log("Ball Pos " + Ball.position.y);
            Ai.position = new Vector3(Ai.position.x, Ball.position.y + 5, Ai.position.z);
        }
    }
}
