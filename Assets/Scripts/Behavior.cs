using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    public GerarÁrvore arvore;

    public GameObject Attack;
    public int lifes = 3;
    public float time = 10f;
    public Transform attackPos;
    public Life life;
    public bool invincible = false;
    
    // Start is called before the first frame update
    void Start()
    {
        arvore.geraArvore(lifes);
           
    }


    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            time -= Time.deltaTime;
        }
        else{
            BossAttack();
            time = 15f;
            arvore.geraArvore(lifes);
        }
        if(lifes == 2){
            transform.gameObject.tag = "Azul";
        }

        if(lifes == 1){
            transform.gameObject.tag = "Vermelho";
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        string cor = collision.gameObject.tag;
        if(gameObject.CompareTag(cor)){
            lifes--;
        }
    }

    
    void BossAttack(){
       
    }
}
