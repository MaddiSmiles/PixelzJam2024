using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customers : MonoBehaviour
{
    public string Name;
    public bool isBig;
    public Animator walkAnim;
    public Animator bubbleAnim;
    private SpriteRenderer spriteRenderer;
    public Sprite sitting;
    public Sprite head;
    public GameObject cup;
    public int vol;
    public GameObject WaterMiniGame;
    public GameObject MainGame;
    public GameObject bubbleObject;
    private bool isInside = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        walkAnim = GetComponent<Animator>();
        bubbleAnim = bubbleObject.GetComponent<Animator>();
        StartCoroutine(CheckToEnter());
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

      private IEnumerator CheckToEnter()
    {
        while (true)
        {
            yield return new WaitForSeconds(30f);

            if (!isInside)
            {
                if (Random.Range(0, 3) == 0) // 1/3 chance
                {
                    Enter();
                }
            }
        }
    }

    private void Enter()
    {
        walkAnim.SetTrigger("Enter");
    }

    public void StartOrder()
    {
        spriteRenderer.sprite = sitting;
        Debug.Log(Name + " is ready to order!");
        walkAnim.enabled = false;
        bubbleAnim.SetTrigger("bubbleAppear");
        isInside = true;
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
        walkAnim.SetBool("Leaving", true);
        cup.SetActive(true);
        WaterMiniGame.GetComponent<WaterMiiniGame>().ResetMiniGame();
        WaterMiniGame.GetComponent<WaterMiiniGame>().customerSetUp(Name);

    }
    public void WalkBack()
    {
        bubbleAnim.SetBool("isLeave",true);
        walkAnim.enabled = true;
        spriteRenderer.flipX = false;
        
    }
}