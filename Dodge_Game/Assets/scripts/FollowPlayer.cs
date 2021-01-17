using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //Vector3 sert à choisir une position précise pour un objet
                           // La c'est pour que la caméra suive le joueur avec une distance (pour pas etre en vue fps
  

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset + new Vector3(0, 1, 0);
    }
}
 