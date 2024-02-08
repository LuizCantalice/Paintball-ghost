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
            gameObject.GetComponent<Ghost_move_blue>().IsOnTree = false;
        }

        if(titulo == "Morte"){
            Destroy(gameObject);
            gameObject.GetComponent<Ghost_move_blue>().IsOnTree = false;

        }
        
        if(titulo == "Player"){
            //life.DecreaseLife();
            collision.gameObject.GetComponent<Life>().DecreaseLife();
            Destroy(gameObject);
            gameObject.GetComponent<Ghost_move_blue>().IsOnTree = false;
        }

    }
}

 
