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
       if(!GameManager.Instance.isGameActive){
            bool isPressingEnter = Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter);
            if(isPressingEnter){
                GameManager.Instance.RestartGame();
            }
           return;
       }
       bool isPressingLeft = Input.GetKey(KeyCode.LeftArrow);
       bool isPressingRight = Input.GetKey(KeyCode.RightArrow);

       if(isPressingLeft == isPressingRight){
        return;
       }
       float tempo = Time.deltaTime;
       float movement = Input.GetAxis("Horizontal") * tempo * speed;
       float limit = (GameManager.Instance.gameWidth /2)-1.5f;
       float x = Mathf.Clamp(transform.position.x + movement,-limit,limit);
       float y = transform.position.y;
       float z = transform.position.z;
       transform.position = new Vector3(x,y,z);
    }
}
