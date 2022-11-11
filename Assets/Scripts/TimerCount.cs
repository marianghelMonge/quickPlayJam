using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCount : MonoBehaviour
{
    [SerializeField]  
     private TextMeshProUGUI timeTxt;
    [SerializeField]  
     private GameObject timeTxtObject;
     private float time = 10.0f;
     private string timer = "";
     public bool timerOut= false;
     private bool isFloorHero = true;
     [SerializeField] Color32 available = new Color(1,1,1,1);
     [SerializeField] Color32 danger = new Color(1,1,1,1);
     [SerializeField] Color32 mistery = new Color(1,1,1,1);
      SpriteRenderer spriteRenderer;
     [SerializeField] public bool[] valueRound = new bool[]{ true, true, false};
    private bool getValueRound=false;
    private int roundNum=0;
    public CapsuleCollider2D box_foot;
    Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
      //  bar = GameObject.Find("enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
       timerDecrease();
        validateIsPlayerInFloor();
      // transform.position = new Vector3(bar.position.x, transform.position.y, transform.position.z);
    }

    private void timerDecrease(){
        if(time > 0){
            time -= Time.deltaTime;
            timer = timeTxt.text = time.ToString("0");
        }else{
            timeTxtObject.SetActive(false);
            timerOut=true;
            roundColor(roundNum);
        }
    }

    private void resetTimer(){
        timeTxtObject.SetActive(true);
        time = 10.0f;        
        timerOut=false;
    }

    //Player inside of a trigger 
    private void OnTriggerStay2D(Collider2D box_foot) {
       // if(box_foot.gameObject.tag == "player"){
            //isFloorHero = true;
           //roundColor(roundNum);
          
       // }else{
           // isFloorHero = false;
     //   }
    }    


    private void validateIsPlayerInFloor(){
        if( timerOut == true ){
            Debug.Log(getValueRound);
            Debug.Log(isFloorHero);
            if(isFloorHero == getValueRound){
                resetTimer();
                Debug.Log("Fire");
            }else{
                Debug.Log("F");
                //monster animation
                //monster movement
            }
        }
    }

    private void roundColor(int i){  
        if(i < 3){
            getValueRound  = valueRound[i];  
            if(getValueRound){
                spriteRenderer.color = mistery;
            }else{
                spriteRenderer.color = danger;
            }
            int RoundNum = 0;
            roundNum = RoundNum++;
        }    
    }
}
