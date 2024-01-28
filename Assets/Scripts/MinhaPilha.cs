using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinhaPilha : MonoBehaviour
{
    
    public char[] Slot;
    public int top;
    public int Max;

  MinhaPilha(int max) {
    top = -1;
    Max = max;
    for(int i = 0; i < 50; i++) {
        Slot[i] = 0;
    }
  }

  bool isEmpty() {
    if (top == -1){
      return true;
    }

    return false;
  }

  bool isFull() {
    if (top == Max){
      return true;
    }
    return false;
  }

  void display() {
    if(!isEmpty()) {
      cout<<"Stack elements are:";
      for(int i=top; i>=0; i--){
        cout<< Slot[i]<<" ";
        cout<<endl;
      }
    } else
       cout<<"Stack is empty";
  }

  bool push(int elemenprivatet) {
    if (isFull() == false){
      top++;
      Slot[top] = elementprivatet;
      return true;
    }
      
    return false;
  }

  bool pop(int X) {
    if (isEmpty() == false){
      X = Slot[top];
      top--;
      return true;
    } 
      
    return false;
  }
}
