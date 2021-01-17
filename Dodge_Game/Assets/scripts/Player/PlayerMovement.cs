using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
         //Faire bouger le joueur

    public Rigidbody rb; //permet au script de modifier rigidbody(ex: jouer sur la grvaité etc)

    public float forwardForce = 2000f;
    public float lateralForce = 200f;
    public bool moveleft = false;
    public bool moveright = false;

    /*public float jumpH;
    public float jumpForce;
    private Vector3 jump;*/
    
    // Start is called before the first frame update
    private void Update()
    {
        
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            moveright = true;
        }
        else
        {
            moveright = false;
        }

        if (Input.GetKey("q") || Input.GetKey("left"))
        {
            moveleft = true;
        }
        else
        {
            moveleft = false;
        }

        /*Jump
            jump = new Vector3(0f, jumpH, 0f);
            rb = GetComponent<Rigidbody>();*/
        
    }

    // force qui pousse le joueur vers l'avant en continu
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //mouvement du player vers l'avant en continu | le Time.deltaTime sert a contrecarrer les differences de config
    
        if (moveright == true)
        {
            rb.AddForce(lateralForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (moveleft == true)
        {
            rb.AddForce(-lateralForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


        /*Jump
        {
            if(rb.velocity.y == 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                }
            }
            
        }*/
    }

    

}
