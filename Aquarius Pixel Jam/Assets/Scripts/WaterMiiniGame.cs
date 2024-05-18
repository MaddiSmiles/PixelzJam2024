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
    }
    public void ResetMiniGame()
    {
        Debug.Log("game reset");
        spillsCount.GetComponent<SpillAmount>().spillAmount = 0;
        timer = 30f;

    }
}
