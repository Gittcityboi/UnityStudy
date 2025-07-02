using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private float time;
    private bool isGameover;

    public GameObject gameoverText;
    public Text timeText;
    public Text bestTimeText;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        isGameover = false;
        gameoverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            time += Time.deltaTime;
            timeText.text = "Time:" + time;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Dodge");
            }
        }
    }
    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime", 0f);

        if (time > bestTime)
        {
            bestTime = time;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        bestTimeText.text = "Best Time : " + bestTime;

    }
}
