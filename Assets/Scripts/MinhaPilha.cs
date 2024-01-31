using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MinhaPilha
{
    public char[] Slot;
    public int top;
    public int Max;

public  MinhaPilha(int max) {
    top = -1;
    Max = max;
    Slot = new char[max];
    for(int i = 0; i < max; i++) {
        Slot[i] = 'e';
    }
  }

 public bool isEmpty() {
    if (top == -1){
      return true;
    }

    return false;
  }

 public bool isFull() {
    if (top == Max){
      return true;
    }
    return false;
  }


  public bool push(char element) {
    if (isFull() == false){
      Debug.Log("Pushing " + element);
      top++;
      Slot[top] = element;
      return true;
    }

    return false;
  }

  public char pop() {
    char x = 'e';
    if (isEmpty() == false){
      x = Slot[top];
      top--;
    } 

    return x;
  }
}
