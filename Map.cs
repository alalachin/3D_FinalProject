using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Map : MonoBehaviour
{

    int[,] map = new int[9, 9];
    // Use this for initialization
    public void Start()
    {

    }
    public void PP()
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                map[i, j] = 0;
            }
        }
        map[0, 1] = 1;
        map[0, 4] = 1;
        map[0, 7] = 1;
        map[1, 2] = 1;
        map[1, 4] = 1;
        map[1, 6] = 1;
        map[1, 8] = 1;
        map[2, 1] = 1;
        map[2, 3] = 1;
        map[2, 5] = 1;
        map[2, 7] = 1;
        map[3, 0] = 1;
        map[3, 4] = 1;
        map[3, 6] = 1;
        map[4, 1] = 1;
        map[4, 3] = 1;
        map[4, 5] = 1;
        map[4, 7] = 1;
        map[5, 0] = 1;
        map[5, 2] = 1;
        map[5, 5] = 1;
        map[5, 8] = 1;
        map[6, 1] = 1;
        map[6, 3] = 1;
        map[6, 5] = 1;
        map[6, 7] = 1;
        map[7, 2] = 1;
        map[7, 4] = 1;
        map[7, 7] = 1;
        map[8, 0] = 1;
        map[8, 3] = 1;
        map[8, 7] = 1;
        print("XXXXXXXXXXXXXXXXXXXXX" + map[8, 7]);

    }
    public bool IsOkToMove(int row, int col, int dir)
    {
        print("222==========" + map[8, 7]);
        for (int i = 0; i < 9; i++)
        {
            print("22");
            for (int j = 0; j < 9; j++)
            {
                //print("2222");
                //print(map[i, j] + " ");
            }
        }
        print("2");
        if (dir == 1) //x up ,ahead
        {
            if (row - 1 >= 0 && map[row - 1, col] == 0)
            {
                map[row, col] = 0;
                map[row - 1, col] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (dir == 2) //x down ,back
        {
            if (row + 1 <= 8 && map[row + 1, col] == 0)
            {
                map[row, col] = 0;
                map[row + 1, col] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (dir == 3) //z up ,left
        {
            if (col - 1 >= 0 && map[row, col - 1] == 0)
            {
                map[row, col] = 0;
                map[row, col - 1] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (dir == 4) //z down ,right
        {
            if (col + 1 <= 8 && map[row, col + 1] == 0)
            {
                map[row, col] = 0;
                map[row, col + 1] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
    // Update is called once per frame
    void update()
    {

    }
}