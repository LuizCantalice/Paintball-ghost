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
    
    public GameObject[] Reds;
    public GameObject[] Greens;
    public GameObject[] Blues;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void geraArvore(int x){
        int Number = Random.Range(0,3);
        if(x == 3){
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

        if(x == 2){
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos1.position, Pos1.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
           else  if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos1.position, Pos1.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos1.position, Pos1.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos2.position, Pos2.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos2.position, Pos2.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos2.position, Pos2.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
        }
        if(x == 1){
             if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos0.position, Pos0.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos0.position, Pos0.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos0.position, Pos0.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos1.position, Pos1.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos1.position, Pos1.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos1.position, Pos1.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos2.position, Pos2.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos2.position, Pos2.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos2.position, Pos2.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos3.position, Pos3.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos3.position, Pos3.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos3.position, Pos3.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos4.position, Pos4.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos4.position, Pos4.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos4.position, Pos4.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos5.position, Pos5.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos5.position, Pos5.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos5.position, Pos5.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
            
            Number = Random.Range(0,3);
            if(Number == 0){
                GameObject GhostRed = Instantiate(GhostPrefabRed, Pos6.position, Pos6.rotation);
                GhostRed.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else if(Number == 1){
                GameObject GhostGreen = Instantiate(GhostPrefabGreen, Pos6.position, Pos6.rotation);
                GhostGreen.GetComponent<Ghost_move_blue>().IsOnTree = true;    
            }
            else{
                GameObject GhostBlue = Instantiate(GhostPrefabBlue, Pos6.position, Pos6.rotation);
                GhostBlue.GetComponent<Ghost_move_blue>().IsOnTree = true;
            }
        }
    }
}
