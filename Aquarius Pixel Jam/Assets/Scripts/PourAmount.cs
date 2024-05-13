using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PourAmount : MonoBehaviour
{   
    public GameObject water;
    int waterAmount = 0;
    public Text FillScore;
    public int filltotal = 200;
    float percent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void  OnParticleCollision()
    {
        waterAmount++;
        percent = ((float)waterAmount / filltotal) * 100f;
        Debug.Log(percent); 
       FillScore.text =  percent.ToString("F1") + "%";
    }
}
