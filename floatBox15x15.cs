/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class floatBox15x15 : MonoBehaviour
{
    public GameObject play;
    public Vector3 temPos;
    public bool isMoving;
    public Quaternion rotation;
    //public Camera viewCamera;
    public GameObject map; //for global map array
    //Transform poOfMap ; // for detect the transform of "play"
    float xOfPo, zOfPo; //for row and col of play
    int xOfMap, zOfMap; //for row and col of play at map
    public GameObject role;//to know the direction of camera
    float yOfRole;
    int dir = 0;
    public Map world;
    void Start()
    {
        world = (Map)map.GetComponent(typeof(Map));
        //GameObject.Find("MapObject").GetComponent<Map>().Start();
        world.PP();


    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isMoving = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;




            if (Physics.Raycast(ray, out hit, 100))
            {
                //    print(hit.collider.name);
                if (hit.collider.gameObject == play)
                {
                    //    Debug.Log(hit.point);


                    temPos = new Vector3(hit.point.x, hit.point.y, play.transform.position.z);

                    if (Vector3.Distance(play.transform.position, temPos) <= 1.4)
                    {
                        isMoving = true;

                    }


                }
            }
        }

        if (Vector3.Distance(play.transform.position, temPos) >= 1.4)
        {
            isMoving = false;
        }

        //to get "play"'s transform and transfer to global map array
        xOfPo = play.GetComponent<Transform>().position.x;
        zOfPo = play.GetComponent<Transform>().position.z;
        xOfMap = (int)(xOfPo + 8);
        zOfMap = (int)((zOfPo - 9) * (-1));

        //to judge the dir of camera
        yOfRole = (int)role.GetComponent<Transform>().rotation.eulerAngles.y;
        if (45 <= yOfRole && yOfRole <= 135)
        {
            dir = 1;
        }
        if (315 >= yOfRole && 225 <= yOfRole)
        {
            dir = 2;
        }
        if ((315 < yOfRole && 360 > yOfRole) || (0 <= yOfRole && 45 > yOfRole))
        {
            dir = 3;
        }
        if (135 < yOfRole && 225 > yOfRole)
        {
            dir = 4;
        }

        if (isMoving)
        {

            play.GetComponent<MeshRenderer>().material.color = Color.red;
            //    this.GetComponent<CharacterController>().SimpleMove((temPos - play.transform.position).normalized * 10f);
            if (Input.GetKey(KeyCode.X))
            {

                if (world.IsOkToMove(zOfMap, xOfMap, dir) == true)
                {
                    if (dir == 1) //x up
                    {
                        play.gameObject.transform.position += new Vector3(1f, 0f, 0f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 2) //x down
                    {
                        play.gameObject.transform.position += new Vector3(-1f, 0f, 0f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 3) //z up
                    {
                        play.gameObject.transform.position += new Vector3(0f, 0f, 1f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 4) //z down
                    {
                        play.gameObject.transform.position += new Vector3(0f, 0f, -1f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                }
            }
        }
        else
        {
            play.GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }




}*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class floatBox15x15 : MonoBehaviour
{
    public GameObject play;
    public Vector3 temPos;
    public bool isMoving;
    public Quaternion rotation;
    //public Camera viewCamera;
    public GameObject map; //for global map array
    //Transform poOfMap ; // for detect the transform of "play"
    float xOfPo, zOfPo; //for row and col of play
    int xOfMap, zOfMap; //for row and col of play at map
    public GameObject role;//to know the direction of camera
    float yOfRole;
    int dir = 0;
    public Map15x15 world;
    void Start()
    {
        world = (Map15x15)map.GetComponent(typeof(Map15x15));
        //GameObject.Find("MapObject").GetComponent<Map>().Start();
        world.PP();


    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isMoving = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;




            if (Physics.Raycast(ray, out hit, 100))
            {
                //    print(hit.collider.name);
                if (hit.collider.gameObject == play)
                {
                    //    Debug.Log(hit.point);


                    temPos = new Vector3(hit.point.x, hit.point.y, play.transform.position.z);

                    if (Vector3.Distance(play.transform.position, temPos) <= 1.4)
                    {
                        isMoving = true;

                    }


                }
            }
        }

        if (Vector3.Distance(play.transform.position, temPos) >= 1.4)
        {
            isMoving = false;
        }

        //to judge the dir of camera
        yOfRole = (int)role.GetComponent<Transform>().rotation.eulerAngles.y;
        if (45 <= yOfRole && yOfRole <= 135)
        {
            dir = 1;
        }
        if (315 >= yOfRole && 225 <= yOfRole)
        {
            dir = 2;
        }
        if ((315 < yOfRole && 360 > yOfRole) || (0 <= yOfRole && 45 > yOfRole))
        {
            dir = 3;
        }
        if (135 < yOfRole && 225 > yOfRole)
        {
            dir = 4;
        }

        if (isMoving)
        {

            //to get "play"'s transform and transfer to global map array
            xOfPo = play.GetComponent<Transform>().position.x;
            zOfPo = play.GetComponent<Transform>().position.z;
            xOfMap = (int)Math.Round(((xOfPo - 3.9f) * (-1) / 0.6f));
            zOfMap = (int)Math.Round(((zOfPo - 4.5f) * (-1) / 0.6f));
            print("xOfPo===" + xOfPo);
            print("zOfPo===" + zOfPo);
            print("===xOfMap===" + xOfMap);
            print("===zOfMap===" + zOfMap);

            play.GetComponent<MeshRenderer>().material.color = Color.red;
            //    this.GetComponent<CharacterController>().SimpleMove((temPos - play.transform.position).normalized * 10f);
            if (Input.GetKey(KeyCode.X))
            {

                if (world.IsOkToMove(xOfMap, zOfMap, dir) == true)
                {
                    if (dir == 1) //x up
                    {
                        play.gameObject.transform.position += new Vector3(0.6f, 0f, 0f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 2) //x down
                    {
                        play.gameObject.transform.position += new Vector3(-0.6f, 0f, 0f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 3) //z up
                    {
                        play.gameObject.transform.position += new Vector3(0f, 0f, 0.6f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                    else if (dir == 4) //z down
                    {
                        play.gameObject.transform.position += new Vector3(0f, 0f, -0.6f);
                        play.GetComponent<MeshRenderer>().material.color = Color.black;
                    }
                }
            }
        }
        else
        {
            play.GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }




}