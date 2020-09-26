using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-0.5f, 0f, 0f);
        }


        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(0.5f, 0f, 0f);
        }


        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(0f, 0f, 0.5f);
        }


        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0f, 0f, -0.5f);
        }



    }
}
