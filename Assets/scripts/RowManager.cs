using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowManager : MonoBehaviour
{
    public bool DelteBlock;
    public int FilledBlockCount;
    // Start is called before the first frame update
    void Start()
    {
        DelteBlock = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(FilledBlockCount);
    }

    public void FilledBlockCheck(){
        if(FilledBlockCount >= 10){
            DelteBlock = true;
        }

    }
}
