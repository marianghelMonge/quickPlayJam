using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCount : MonoBehaviour
{
    [SerializeField]  
     private TextMeshProUGUI timeTxt;
     private float time = 10.0f;
     private string timer = "";
     private bool isFloorHero = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer = timeTxt.text = time.ToString("0");
    }

    private void OnTriggerEnter2D(Collider2D player) {
        if(player.gameObject.tag == "player"){
            isFloorHero = true;
        }else{
            isFloorHero = false;
        }
        validateIsPlayerInFloor();
    }
    
    private void validateIsPlayerInFloor(){
        if( time <= 1 ){
            if(isFloorHero == true){
                Debug.Log("Seguimos");
            }else{
                Debug.Log("Paramos");
            }
        }
    }

    private void timerON(){

    }

    private void timerOFF(){
        
    }
}
