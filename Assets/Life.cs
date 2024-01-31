using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int CurrLifes;
    public int MaxLifes = 3;
    // Start is called before the first frame update
     void Start()
    {
        CurrLifes = MaxLifes;
    }
    
    public void DecreaseLife(){
        CurrLifes--;
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
