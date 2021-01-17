using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) //sert a savoir si y'a une collision et avec quoi
    {
        if (collisionInfo.collider.tag == "Obstacle") //fonction.ce qu'on veut savoir.objet
                                                      //tag = une catégorie d'objet.
        {
            movement.enabled = false; //pour arreter la course du joueur #findegame ca désactive le script movement du player
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
