using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollisionManager : MonoBehaviour
{
    public  Life life;
void OnCollisionEnter2D(Collision2D collision)
    {
        string titulo = collision.gameObject.tag;
        if(gameObject.CompareTag(titulo)){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if(titulo == "chão"){
            Destroy(gameObject);
        }
        
        if(titulo == "Player"){
            Destroy(gameObject);
            life.DecreaseLife();
        }

    }
}

 
