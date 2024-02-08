using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
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
    
    public int[] arvore;

    public GameObject[] inimigos;

    public GameObject[] Reds;
    public GameObject[] Greens;
    public GameObject[] Blues;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < 7; i++)
        {
            arvore[i] = Random.Range(0,3);
        }
    }

    // Update is called once per frame

    void Update(){
        for (int i = 0; i < 7; i++)
        {
            parentIsDead(inimigos[i]);
        }
        
    }

    public bool parentIsDead(GameObject gameObject){
        if ()
        {
            
        }
    }

    public void geraArvore(int x){
        
        if(x == 3){
            if(arvore[0] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;  
                inimigos[0] = GhostRed;    
            }
            if(arvore[0] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[0] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[0] = GhostBlue;
            }
        }

        if(x == 2){
            if(arvore[0] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[0] = GhostRed; 
            }
            else if(arvore[0] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[0] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[0] = GhostBlue;
            }
            
            
            if(arvore[1] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos1.position, Pos1.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;   
                inimigos[1] = GhostRed;  
            }
           else  if(arvore[1] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos1.position, Pos1.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[1] = GhostGreen;   
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos1.position, Pos1.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[1] = GhostBlue;
            }
            
            
            if(arvore[2] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos2.position, Pos2.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[2] = GhostRed; 
            }
            else if(arvore[2] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos2.position, Pos2.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[2] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos2.position, Pos2.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[2] = GhostBlue;
            }
        }
        if(x == 1){
             if(arvore[0] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[0] = GhostRed; 
            }
            else if(arvore[0] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[0] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[0] = GhostBlue;
            }
            
            
            if(arvore[1] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos1.position, Pos1.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[1] = GhostRed; ;
            }
            else if(arvore[1] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos1.position, Pos1.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[1] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos1.position, Pos1.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[1] = GhostBlue;
            }
            
            
            if(arvore[2] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos2.position, Pos2.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[2] = GhostRed; 
            }
            else if(arvore[2] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos2.position, Pos2.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[2] = GhostGreen;   
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos2.position, Pos2.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[2] = GhostBlue;
            }
            

            if(arvore[3] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos3.position, Pos3.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;   
                inimigos[3] = GhostRed;  
            }
            else if(arvore[3] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos3.position, Pos3.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[3] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos3.position, Pos3.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[3] = GhostBlue;
            }
            
            
            if(arvore[4] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos4.position, Pos4.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[4] = GhostRed; 
            }
            else if(arvore[4] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos4.position, Pos4.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;  
                inimigos[4] = GhostGreen;      
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos4.position, Pos4.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[4] = GhostBlue;
            }
            

            if(arvore[5] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos5.position, Pos5.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[5] = GhostRed; 
            }
            else if(arvore[5] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos5.position, Pos5.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true; 
                inimigos[5] = GhostGreen;       
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos5.position, Pos5.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[5] = GhostBlue;
            }
            
            
            if(arvore[6] == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos6.position, Pos6.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;   
                inimigos[6] = GhostRed;  
            }
            else if(arvore[6] == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos6.position, Pos6.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
                inimigos[6] = GhostGreen;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos6.position, Pos6.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
                inimigos[6] = GhostBlue;;
            }
        }
    }
}
