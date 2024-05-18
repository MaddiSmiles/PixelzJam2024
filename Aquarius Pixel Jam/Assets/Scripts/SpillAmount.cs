using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpillAmount : MonoBehaviour
{   
    public int spillAmount = 0;
    public Text SpillScore;
    public int errorAmount;
    public int spillTip = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spillTip = (spillAmount / 30)*(-1);
    }
     private void  OnParticleCollision()
    {
        spillAmount++;
      SpillScore.text = "Spilt: " +spillAmount.ToString();
    }
}
