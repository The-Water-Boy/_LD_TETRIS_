using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiles : MonoBehaviour
{
    private GameObject checker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.parent.GetComponent<RowManager>().FilledBlockCount == 10){
            Destroy(checker.gameObject);
        }
    }

    void OnTriggerEnter(Collider other){
        checker = other.gameObject;
        transform.parent.GetComponent<RowManager>().FilledBlockCount+=1;
        
    }

    void OnTriggerExit(Collider other){
        transform.parent.GetComponent<RowManager>().FilledBlockCount-=1;
    }
}
