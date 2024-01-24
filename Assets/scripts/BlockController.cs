using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public int movementinterval;
    private int ymovement, xmovement;
    private bool iscontrollable;
    public GameObject tetremino;
    // Start is called before the first frame update
    void Start()
    {
        ymovement = -1;
        movement();
        iscontrollable = true;
    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(iscontrollable){
        if(Input.GetKeyDown(KeyCode.A)){
            transform.Translate(-1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            transform.Translate(1,0,0);
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            tetremino.transform.Rotate(0,0,-90,Space.Self);
        }
        if(Input.GetKeyDown(KeyCode.E)){
            tetremino.GetComponent<Transform>().transform.Rotate(0,0,90,Space.Self);
        }
        }
    }

    void movement(){
        transform.Translate(0,ymovement,0);
        //ymovement++;
        StartCoroutine(Range());
    }

    private IEnumerator Range() {
        yield return new WaitForSeconds(1); //wait 3 seconds
        movement();
    }

    void OnCollisionEnter(Collision other){
        Debug.Log("yaeh");
        if(other.gameObject.tag == "BottomCube"){
            ymovement = 0;
            iscontrollable = false;
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
