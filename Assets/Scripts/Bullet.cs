using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        string cor = collision.gameObject.tag;
        if(gameObject.CompareTag(cor) && !(collision.gameObject.name == "Boss")){
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }


}
