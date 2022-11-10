using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement; //get horizontal and vertical
    // Update is called once per frame
    public Joystick joystick;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    private int countScene=0;
    public GameObject[] BG;
    public CapsuleCollider2D playerBarrier;
   
    void Update()//Input
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
    }
    void FixedUpdate()//movement
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D trigger) {
       if(trigger.gameObject.tag == "background"){
           
            if(countScene==0){
                bg1.SetActive(true);
                bg2.SetActive(false);
                bg3.SetActive(false);
                transform.position = new Vector3(-3,311,1);
            } if(countScene==1){
                bg1.SetActive(false);
                bg2.SetActive(true);
                bg3.SetActive(false); 
                transform.position = new Vector3(-3,311,1);
               // transform.gameObject.tag = "scene";
            }else{
                bg1.SetActive(false);
                bg2.SetActive(false);
                bg3.SetActive(true);
                transform.position = new Vector3(-3,311,1);
            }
             foreach(GameObject bg in BG)               
                 countScene +=1;
        }
        if(trigger.gameObject.tag == "scene"){
           SceneManager.LoadScene(2);
        }         
    }
}
