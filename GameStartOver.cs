using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartOver : MonoBehaviour
{
    public static GameStartOver Instance;


    public GameObject end;
    public GameObject playButton;
    public bool playing;

    public GameObject RestartButton;
    public GameObject QuitButton;
    public GameObject gameName;


    // Use this for initialization
    void Start()
    {
        Instance = this;
        end.SetActive(false);
        RestartButton.SetActive(false);
        QuitButton.SetActive(true);
        //GameStart();
    }

    // Update is called once per frame
    /*void Update()
    {
        time += Time.deltaTime;
        time2 += Time.deltaTime;
        time3 += Time.deltaTime;


        if (time > 1.0f && playing == true)
        {
            Vector3 pos = new Vector3(12.0f, Random.Range(-6.8f, 6.8f), 0);
            Instantiate(Fish, pos, transform.rotation);
            time = 0f;
        }
        if (time2 > 2.5f && playing == true)
        {
            Vector3 pos = new Vector3(12.0f, Random.Range(-6.8f, 6.8f), 0);
            Instantiate(Clown, pos, transform.rotation);
            time2 = 0f;
        }
        if (time3 > 4.0f && playing == true)
        {
            Vector3 pos = new Vector3(12.0f, Random.Range(-6.8f, 6.8f), 0);
            Instantiate(Jelly, pos, transform.rotation);
            time3 = 0f;
        }
    }
    public void AddScore(int n)
    {
        Score += n;
        scoretext.text = "Score : " + Score;
    }*/
    public void GameStart()
    {

        playing = true;
        gameName.SetActive(false);
        playButton.SetActive(false);
        RestartButton.SetActive(false);
        QuitButton.SetActive(false);

    }
    public void GameOver()
    {

        playing = false;
        end.SetActive(true);
        RestartButton.SetActive(true);
        QuitButton.SetActive(true);

    }
    public void ResetGame()
    {
        //Application.LoadLevel(0);
        Application.LoadLevel(Application.loadedLevel);
    }

    public void QuitGame()
    {

        Application.Quit();
    }
}
