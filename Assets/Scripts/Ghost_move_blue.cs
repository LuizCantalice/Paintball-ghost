using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_move_blue : MonoBehaviour
{

  
    
    private Vector2 moveDirection;
    public Rigidbody2D monsterRb;
    public float speed = 2f;
    public bool IsOnTree = false;
    public int index;


    void movemment ()
    {
       monsterRb.velocity = new Vector2(0, moveDirection.y * speed);
    }
    // Start is called before the first frame update
    void Start()
    {

        moveDirection =  new Vector2(0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOnTree)
        {
            movemment();
        }
        
    }
    
    
}
