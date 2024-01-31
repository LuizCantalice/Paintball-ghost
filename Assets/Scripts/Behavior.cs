using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    public GerarÁrvore arvore;

    public GameObject Attack;
    public int lifes = 3;
    public float time = 2f;
    public Transform attackPos;
    
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/


    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            time -= Time.deltaTime;
        }
        else{
            BossAttack();
            time = 2f;
            arvore.geraArvore(lifes);
        }
        
    }

    public LayerMask whatIsToDamage;
    void BossAttack(){
        Collider2D[] cols = Physics2D.OverlapCircleAll(Vector2.one, 10f, whatIsToDamage);

        foreach(Collider2D col in cols){
            if(col.CompareTag("Player")){
                //col.GetComponent<Life>.DecreaseLife();
            }
            else{
                Destroy(col.gameObject);
            }
        }
         
    }
}
