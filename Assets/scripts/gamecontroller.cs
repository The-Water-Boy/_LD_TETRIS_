using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5;
    public GameObject Block6;
    public GameObject Block7;
    private int count;
    private int firstinline;
    private int secondinline;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        
        BlockRandomiser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlockRandomiser()
    {
        
        if(count == 1){
           firstinline = Random.Range(0,6);
            Debug.Log("first in line "+ firstinline);
            count = 2;
        }
        //if(count == 2){
            secondinline = Random.Range(0,6);
            Debug.Log("first second number "+secondinline);
            Debug.Log("count "+ count);
        //}
        Movingtheque();
    }
    

    private void Movingtheque(){
        //instantiate firstinline block
        if(firstinline == 0){
            Debug.Log("hey");
            Instantiate(Block1);
        }
        if(firstinline == 1){
            //instantiate block
            Debug.Log("hey2");
            Instantiate(Block2);
        }
        if(firstinline == 2){
            //instantiate block
            Debug.Log("hey3");
            Instantiate(Block3);
        }
        if(firstinline == 3){
            //instantiate block
            Debug.Log("hey4");
            Instantiate(Block4);
        }
        if(firstinline == 4){
            //instantiate block
            Debug.Log("hey5");
            Instantiate(Block5);
        }
        if(firstinline == 5){
            //instantiate block
            Debug.Log("hey6");
            Instantiate(Block6);
        }
        if(firstinline == 6){
            //instantiate block
            Debug.Log("hey7");
            Instantiate(Block7);
        }
        
        // number in second position moves to first position
        Debug.Log("old firstinline number "+firstinline);
        firstinline = secondinline;
        Debug.Log("new firstinline number "+firstinline);
        //
        //set new second number
        
    }

    //tilemapchecker
}
