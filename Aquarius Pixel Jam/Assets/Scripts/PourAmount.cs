using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PourAmount : MonoBehaviour
{   
    public GameObject water;
    int waterAmount = 0;
    public Text FillScore;
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
        Debug.Log(waterAmount);
       // FillScore.GetComponent<Text>().text = (waterAmount);

    }
}
