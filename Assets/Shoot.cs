using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bulletPrefabRed;
    public GameObject bulletPrefabGreen;
    public GameObject bulletPrefabBlue;
    public Transform firePoint;
    public float fireForce = 20f;
    public int i = 0;
    public char[] ammo;

    void Atirar()
    {
        if(ammo[i] == 'r'){
            GameObject bulletRed = Instantiate(bulletPrefabRed, firePoint.position, firePoint.rotation);
            bulletRed.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else if(ammo[i] == 'g'){
            GameObject bulletGreen = Instantiate(bulletPrefabGreen, firePoint.position, firePoint.rotation);
            bulletGreen.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else{
            GameObject bulletBlue = Instantiate(bulletPrefabBlue, firePoint.position, firePoint.rotation);
            bulletBlue.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        i++;
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