using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using static Ghost_move_blue;

public class GerarÁrvore : MonoBehaviour
{
    public BinaryTree tree;
    public Behavior behavior;
    public GameObject GhostPrefabBlue;
    public GameObject GhostPrefabRed;
    public GameObject GhostPrefabGreen;
    public Transform Pos0, Pos1, Pos2, Pos3, Pos4, Pos5, Pos6;
    // Start is called before the first frame update
    void Start()
    {
        GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
        GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void geraArvore(int X){
        int Number = Random.Range(0,3);
        if(X == 3){
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;

            }
        }
    }
}
