using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers : MonoBehaviour
{
    public string Name;
    public bool isBig;
    public Animation walkAnim;
    public Sprite sitting;
    public GameObject cup;
    public int vol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartOrder()
    {
        Debug.Log("Order started");
    }
}
