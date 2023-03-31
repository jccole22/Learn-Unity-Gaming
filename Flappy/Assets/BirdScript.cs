using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpSpeed;
    public LogicScript logic;
    bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            //Vector2.up is same
            body.velocity = new Vector2(0, 1) * jumpSpeed;
        }
        
        if (transform.position.y > 8 || transform.position.y < -8)
        {
            logic.GameOver();
            birdIsAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
