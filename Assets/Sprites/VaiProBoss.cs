using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VaiProBoss : MonoBehaviour
{
    public float timer = 30f;
    
    void Update(){
        if(timer > 0){
            timer -= Time.deltaTime;
        }
        else{
            SceneManager.LoadScene(1);
        }
    }
    
}
