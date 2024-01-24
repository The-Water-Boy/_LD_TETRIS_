using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
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

    void BlockRandomiser()
    {
        int number;
        if(count == 1){
           number = Random.Range(0,3);
            firstinline = number;
            Debug.Log(firstinline);
            count++;
        }
        if(count == 2){
            number = Random.Range(0,3);
            secondinline = number;
            Debug.Log(secondinline);
        }
        Movingtheque();
    }

    private void Movingtheque(){
        //instantiate firstinline block
        if(firstinline == 0){
            //instantiate block
        }
        if(firstinline == 1){
            //instantiate block
        }
        if(firstinline == 2){
            //instantiate block
        }
        if(firstinline == 3){
            //instantiate block
        }
        // number in second position moves to first position
        Debug.Log(firstinline);
        firstinline = secondinline;
        Debug.Log(secondinline);
        //
        //decrease count value
        count -=1;
    }

    //tilemapchecker
}
