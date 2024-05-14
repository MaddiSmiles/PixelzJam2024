using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPour : MonoBehaviour
{
       private ParticleSystem particleSystem;
       public GameObject emitter;
       public GameObject FillCup;
    // Start is called before the first frame update
    void Start()
    {
       particleSystem = GetComponentInChildren<ParticleSystem>();
       particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        emitter.transform.position = mousePosition;

        //Checks and pours water when mouse is held
      if(Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play(); // Play the particle system
        }
       if(Input.GetKeyUp(KeyCode.Space))
        {
            particleSystem.Stop(); // Stop the particle system
        }
     }

}
