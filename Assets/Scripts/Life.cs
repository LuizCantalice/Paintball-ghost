using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public int CurrLifes;
    public int MaxLifes = 3;
    // Start is called before the first frame update
     void Start()
    {
        Debug.Log("A");
        CurrLifes = MaxLifes;
    }
    
    public void DecreaseLife(){
        CurrLifes--;
    }

   

    // Update is called once per frame
    void Update()
    {
        if(CurrLifes == 0){
            SceneManager.LoadScene(3);
        }
    }
}
