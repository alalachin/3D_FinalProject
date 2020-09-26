using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewControl : MonoBehaviour {

    public GameObject player;
    public GameObject threeCon;
    public GameObject oneCon;
	// Use this for initialization
	void Start () {
        threeCon.SetActive(false);
        oneCon.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.O)){
            threeCon.SetActive(false);
            oneCon.SetActive(true);
        }
        else if(Input.GetKey(KeyCode.T)){
            threeCon.SetActive(true);
            oneCon.SetActive(false);
        }
	}
}
