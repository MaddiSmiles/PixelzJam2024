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
    public int pourTip;
    public int totalTip;
    public GameObject table;
    public GameObject GameManager;
    // Start is called before the first frame update
    void Start()
    {
        pourTip = 5;
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
        if(percent > 102)
        {
            FillScore.text = ("OverFlowed!");
            pourTip = 3;
        }
        else
        {
            FillScore.text =  percent.ToString("F1") + "%";
        }

        if (percent > 95 && percent < 100)
        {
            pourTip = 7;
        }
    }
    public void FinishPour()
    {
       pourTip -=  table.GetComponent<SpillAmount>().spillTip;
       GameManager.GetComponent<GameManager>().Tips += pourTip;
       pourTip = 5;
       waterAmount = 0;
        FillScore.text = "0%";

    }
}
