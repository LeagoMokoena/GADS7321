using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisMove : MonoBehaviour
{
    public float StartSpeed;
    public float ExtraSpeed;
    public float MaxExtraSpeed;
    public bool player1Start = true;

    private int hitcounter = 0;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    //private void RestartBall()
    //{
    //    rb.velocity = new Vector2(627, 332); //(627, 332);
    //    transform.position = new Vector2(627, 332);
    //}

    public IEnumerator Launch()
    {
        //RestartBall();
        hitcounter = 0;

        yield return new WaitForSeconds(1);

        //if (player1Start == true)
        //{
            MoveBall(new Vector2(-1, 0));
        //}
        //else
        //{
            MoveBall(new Vector2(1, 0));
        //}
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = StartSpeed + hitcounter * ExtraSpeed;

        rb.velocity = direction * ballSpeed;
    }

    public void IncreaseCounter()
    {
        if (hitcounter * ExtraSpeed < MaxExtraSpeed)
        {
            hitcounter++;
        }
    }

    
   
}
