using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 100f;
    public float rotationSpeed = 900f;
    public Transform target;
    // Start is called before the first frame update
    
    void ProjectileMove(){
        Vector3 direction = transform.position - target.position;
        direction = -direction.normalized;
        transform.rotation = Quaternion.LookRotation(transform.forward, direction);
        transform.position += direction * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        ProjectileMove();
    }
}
