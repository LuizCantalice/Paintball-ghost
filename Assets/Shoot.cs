using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bulletPrefabRed;
    //public GameObject bulletPrefabGreen;
    //public GameObject bulletPrefabBlue;
    public Transform firePoint;
    public float fireForce = 20f;

//AAAAAAAAAAAAAAAAAAAAAAAAAAAAA

    void Atirar()
    {
        GameObject bulletRed = Instantiate(bulletPrefabRed, firePoint.position, firePoint.rotation);
        bulletRed.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }

    
}