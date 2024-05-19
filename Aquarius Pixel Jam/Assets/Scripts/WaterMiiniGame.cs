using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterMiiniGame : MonoBehaviour
{
    public float time = 30f;
    private float timer = 0f;
    public Text Timer;
    private bool MiniGameOver = false;
    public int miniTipTotal = 0;
    public GameObject MainGame;
    public GameObject spillsCount;
    public GameObject ConversationManager;
    public string CustomerName;
    public GameObject CurrentCustomer;
    public GameObject Cup;
    public GameObject UIHead;
    private Sprite head;
    public GameObject Axolotl;
    public GameObject Wife;
    public GameObject Cetea;
    public GameObject Cetus;
    public GameObject Dumbo;
    public GameObject FishDude;
    public GameObject Hippocampi;
    public GameObject Nessie;
    public GameObject SeaMonkey;
    public GameObject Siren;

    // Start is called before the first frame update
    void Start()
    {
        timer = time;
    }

    // Update is called once per frame
void Update()
    {
        if (!MiniGameOver)
        {
            if (timer > 0f)
            {
                timer -= Time.deltaTime;
                UpdateTimerUI(timer);
                if (timer <= 0f)
                {
                    MiniGameOver = true;
                    FinishMiniGame();
                    Debug.Log("MiniGame Over");
                }
            }
        }
    }

     void UpdateTimerUI(float timeRemaining)
    {
        int seconds = Mathf.FloorToInt(timeRemaining);
        string timeString = seconds.ToString();
        Timer.text = timeString;
    }

    public  void FinishMiniGame()
    {
        MainGame.SetActive(true);
        gameObject.SetActive(false);
        Cup.SetActive(false);
        Cup.GetComponent<PourAmount>().FinishPour();
        CurrentCustomer.GetComponent<Customers>().WalkBack();
    }
    public void ResetMiniGame()
    {
        Debug.Log("game reset");
        spillsCount.GetComponent<SpillAmount>().spillAmount = 0;
        timer = 30f;
        ConversationManager.SetActive(true);

    }
    public void customerSetUp(string customerName)
    {
        Debug.Log(customerName + " is ordering!");
        if (customerName == "Axolotl")
        {
            CurrentCustomer = Axolotl;
        }
        else if (customerName == "AxolotlWife")
        {
            CurrentCustomer = Wife;
        }
        else if (customerName == "Cetea")
        {
            CurrentCustomer = Cetea;
        }
        else if (customerName == "Cetus")
        {
            CurrentCustomer = Cetus;
        }
               else if (customerName == "FishDude")
        {
            CurrentCustomer = FishDude;
        }
        else if (customerName == "Dumbo")
        {
            CurrentCustomer = Dumbo;
        }
        else if (customerName == "Hippocampi")
        {
            CurrentCustomer = Hippocampi;
        }
        else if (customerName == "Nessie")
        {
            CurrentCustomer = Nessie;
        }
        else if (customerName == "SeaMonkey")
        {
            CurrentCustomer = SeaMonkey;
        }
        else if (customerName == "Siren")
        {
            CurrentCustomer = Siren;
        }

        Customers customerComponent = CurrentCustomer.GetComponent<Customers>();
        Cup = customerComponent.cup;
        head = customerComponent.head;
        UIHead.GetComponent<Image>().sprite = head;
    }
}
