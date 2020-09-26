using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public float time;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        /*if(Input.GetKeyDown(KeyCode.R)){
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (Application.loadedLevel == 0)
                Application.LoadLevel(1);
            else
                Application.LoadLevel(0);
        }*/
        if (time > 18f)
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene(1);
        }
    }
}
