using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Map5x5 : MonoBehaviour
{

    int[,] map = new int[9, 9];
    // Use this for initialization
    public void Start()
    {

    }
    public void PP()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                map[i, j] = 0;
            }
        }
        map[0, 3] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[1, 4] = 1;
        map[2, 0] = 1;
        map[2, 3] = 1;
        map[3, 1] = 1;
        map[3, 3] = 1;
        map[3, 4] = 1;
        map[4, 0] = 1;
        map[4, 2] = 1;

    }
    public bool IsOkToMove(int row, int col, int dir)
    {

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
            if (row + 1 <= 4 && map[row + 1, col] == 0)
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
            if (col + 1 <= 4 && map[row, col + 1] == 0)
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