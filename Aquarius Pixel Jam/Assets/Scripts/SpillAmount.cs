using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpillAmount : MonoBehaviour
{   
    int spillAmount = 0;
    public Text SpillScore;
    public int errorAmount;
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
        spillAmount++;
      SpillScore.text = "Split: " +spillAmount.ToString();
    }
}
