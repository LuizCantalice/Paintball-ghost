using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class Shoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject bulletPrefabRed;
    public GameObject bulletPrefabGreen;
    public GameObject bulletPrefabBlue;
    public Transform firePoint;
    public float fireForce = 20f;
    public char cor;
    public MinhaPilha ammo;
    public Canvas canvas;
    public bool IsOnMenu = false;
    
    void Atirar()
    { 
        cor = ammo.pop();

        if(cor == 'r'){
            GameObject bulletRed = Instantiate(bulletPrefabRed, firePoint.position, firePoint.rotation);
            bulletRed.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else if(cor == 'g'){
            GameObject bulletGreen = Instantiate(bulletPrefabGreen, firePoint.position, firePoint.rotation);
            bulletGreen.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
        else if(cor == 'b'){
            GameObject bulletBlue = Instantiate(bulletPrefabBlue, firePoint.position, firePoint.rotation);
            bulletBlue.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
    
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("inferno");
        ammo = new MinhaPilha(6);
        RecarregaVermelho();
        RecarregaVerde();
        RecarregaAzul();
        RecarregaVermelho();
        RecarregaVerde();
        RecarregaAzul();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !(IsOnMenu))
        {
            Atirar();
        }
        if(Input.GetKeyDown(KeyCode.R)){
            IsOnMenu = true;
            canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);
            if(canvas.gameObject.activeSelf){
                Time.timeScale = 0.01f;
            }
            else{
                Time.timeScale = 1f;
                IsOnMenu = false;
            }
        }

    }

    public void RecarregaVermelho(){
        ammo.push('r');
    }

    public void RecarregaVerde(){
        ammo.push('g');
    }

    public void RecarregaAzul(){
        ammo.push('b');
    }


}