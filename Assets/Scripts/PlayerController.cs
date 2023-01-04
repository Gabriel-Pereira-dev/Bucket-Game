using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed= 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       bool isPressingLeft = Input.GetKey(KeyCode.LeftArrow);
       bool isPressingRight = Input.GetKey(KeyCode.RightArrow);

       if(isPressingLeft == isPressingRight){
        return;
       }
       float tempo = Time.deltaTime;
       float movement = Input.GetAxis("Horizontal") * tempo * speed;
       
       transform.position += new Vector3(movement,0,0);
       Debug.Log("Mexeu: "+ movement);
    }
}
