using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MiniGame;
    public float time = 300f;
    private float timer = 0f;
    private bool gameOver = false;
    public Text Clock;
    public Text TipText;
    public int Tips;

    // Start is called before the first frame update
    void Start()
    {
        timer = time; 
    }

    // Update is called once per frame
    void Update()
    {   
        TipText.text = "$" + Tips.ToString();
        if (!gameOver)
        {
            if (timer > 0f)
            {
                timer -= Time.deltaTime;
                UpdateTimerUI(timer);
                if (timer <= 0f)
                {
                    gameOver = true;
                    Debug.Log("Game Over");
                }
            }
        }
    }

    void UpdateTimerUI(float timeRemaining)
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        Clock.text = timeString;
    }
}