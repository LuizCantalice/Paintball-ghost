using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recarga : MonoBehaviour
{
    public GameObject player;
    public void ReloadRed(){
        player.GetComponent<Shoot>().RecarregaVermelho();
    }
    
    public void ReloadGreen(){
        player.GetComponent<Shoot>().RecarregaVerde();
    }

    public void ReloadBlue(){
        player.GetComponent<Shoot>().RecarregaAzul();
    }
}
