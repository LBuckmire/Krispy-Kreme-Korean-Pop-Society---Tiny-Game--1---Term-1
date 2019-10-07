using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f; // this is the speed of which the player will move
    public float mappingwidth = 5f; // this shows the distance the player can move from left to right
    private Rigidbody2D rb;
    bool facingright = true;
    float velx;
    float vely;
    Rigidbody2D rigbody;



    #region check for rigidbody on the player
    void Start() // this checks for the rigidbody of the players object
    {
        rb = GetComponent<Rigidbody2D>();
        rigbody = GetComponent<Rigidbody2D>();
        gameObject.name = "Player";
    }
    #endregion

    #region Player Movement
    void FixedUpdate() // this calculates how the player will move and i have written it so the player can only move left and right
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mappingwidth, mappingwidth);
        

        rb.MovePosition(newPosition);
    }
    #endregion

    void Update()
    {
        velx = Input.GetAxisRaw("Horizontal");
        vely = rigbody.velocity.y;
        rigbody.velocity = new Vector2(velx * speed, vely);
    }


    void LateUpdate()
    {
        Vector3 localscale = transform.localScale;
        if(velx > 0)
        {
            facingright = true;
        }
        else if (velx < 0)
        {
            facingright = false;
        }

        if (((facingright) && (localscale.x < 0)) || ((!facingright) && (localscale.x > 0)))
        {
            localscale.x *= -1;
        }
        transform.localScale = localscale;
    }



    #region Lives Takeaway
    void OnTriggerEnter2D(Collider2D col) // when a player hits an object it removes one heart from three lives
    {
        Healthcontrol.health -= 1;
    }
    #endregion
}
