using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void loadMenu(){
        SceneManager.LoadScene("menu");
    }
}
