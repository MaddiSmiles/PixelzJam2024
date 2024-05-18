using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers : MonoBehaviour
{
    public string Name;
    public bool isBig;
    public Animator walkAnim;
    private Animator bubbleAnim;
    int seatChosen = 1;
    private SpriteRenderer spriteRenderer;
    public Sprite sitting;
    public GameObject cup;
    public int vol;
    public GameObject WaterMiniGame;
    public GameObject MainGame;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        walkAnim = GetComponent<Animator>();
        GameObject bubbleObject = GameObject.Find("seat" + seatChosen + "Bubble");
        bubbleAnim = bubbleObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (bubbleAnim.GetBool("IsEnter"))
            {
                StartMiniGame();
            }
        }
    }

    public void StartOrder()
    {
        spriteRenderer.sprite = sitting;
        Debug.Log(Name + " is ready to order!");
        walkAnim.enabled = false;
        bubbleAnim.SetTrigger("bubbleAppear");
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("entered circle");
        if (other.gameObject.tag == "Player")
        {
            bubbleAnim.SetBool("IsEnter", true);
        }
    }

    // OnTriggerExit is called when the Collider other exits the trigger
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            bubbleAnim.SetBool("IsEnter", false);
        }
    }

    void StartMiniGame()
    {
        Debug.Log(Name + " is thirsty!");
        MainGame.SetActive(false);
        WaterMiniGame.SetActive(true);
        WaterMiniGame.GetComponent<WaterMiiniGame>().ResetMiniGame();

    }
}