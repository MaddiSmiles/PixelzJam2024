using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPour : MonoBehaviour
{
       private ParticleSystem particleSystem;
       public GameObject emitter;
       public GameObject Arm;
       public Sprite ArmOn;
       public Sprite ArmOff;
       private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
       particleSystem = GetComponentInChildren<ParticleSystem>();
       particleSystem.Stop();
       spriteRenderer = Arm.GetComponent<SpriteRenderer>();
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
           spriteRenderer.sprite = ArmOn;
        }
       if(Input.GetKeyUp(KeyCode.Space))
        {
            particleSystem.Stop(); // Stop the particle system
            spriteRenderer.sprite = ArmOff;
        }
     }

    public void StopWater()
    {
        particleSystem.Stop();
    }

}
