/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Map15x15 : MonoBehaviour
{

    int[,] map = new int[9, 9];
    // Use this for initialization
    public void Start()
    {

    }
    public void PP()
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                map[i, j] = 0;
            }
        }
        map[0, 1] = 1;
        map[0, 4] = 1;
        map[0, 6] = 1;
        map[0, 8] = 1;
        map[0, 11] = 1;
        map[0, 14] = 1;
        map[1, 2] = 1;
        map[1, 3] = 1;
        map[1, 5] = 1;
        map[1, 7] = 1;
        map[1, 8] = 1;
        map[1, 10] = 1;
        map[1, 12] = 1;
        map[2, 0] = 1;
        map[2, 2] = 1;
        map[2, 6] = 1;
        map[2, 11] = 1;
        map[2, 13] = 1;
        map[3, 2] = 1;
        map[3, 4] = 1;
        map[3, 6] = 1;
        map[3, 7] = 1;
        map[3, 9] = 1;
        map[3, 10] = 1;
        map[3, 11] = 1;
        map[3, 12] = 1;
        map[3, 14] = 1;
        map[4, 0] = 1;
        map[4, 1] = 1;
        map[4, 3] = 1;
        map[4, 6] = 1;
        map[4, 8] = 1;
        map[4, 12] = 1;
        map[5, 0] = 1;
        map[5, 4] = 1;
        map[5, 5] = 1;
        map[5, 7] = 1;
        map[5, 9] = 1;
        map[5, 11] = 1;
        map[5, 13] = 1;
        map[6, 2] = 1;
        map[6, 7] = 1;
        map[6, 9] = 1;
        map[6, 10] = 1;
        map[6, 14] = 1;
        map[7, 1] = 1;
        map[7, 3] = 1;
        map[7, 5] = 1;
        map[7, 6] = 1;
        map[7, 8] = 1;
        map[7, 10] = 1;
        map[7, 12] = 1;
        map[7, 13] = 1;
        map[8, 5] = 1;
        map[8, 7] = 1;
        map[8, 8] = 1;
        map[8, 11] = 1;
        map[8, 14] = 1;
        map[9, 0] = 1;
        map[9, 2] = 1;
        map[9, 3] = 1;
        map[9, 4] = 1;
        map[9, 6] = 1;
        map[9, 8] = 1;
        map[9, 10] = 1;
        map[9, 12] = 1;
        map[10, 1] = 1;
        map[10, 5] = 1;
        map[10, 9] = 1;
        map[10, 10] = 1;
        map[10, 13] = 1;
        map[11, 0] = 1;
        map[11, 2] = 1;
        map[11, 4] = 1;
        map[11, 6] = 1;
        map[11, 7] = 1;
        map[11, 9] = 1;
        map[11, 11] = 1;
        map[11, 14] = 1;
        map[12, 0] = 1;
        map[12, 2] = 1;
        map[12, 3] = 1;
        map[12, 4] = 1;
        map[12, 7] = 1;
        map[12, 8] = 1;
        map[12, 10] = 1;
        map[12, 12] = 1;
        map[12, 13] = 1;
        map[13, 1] = 1;
        map[13, 6] = 1;
        map[13, 11] = 1;
        map[13, 14] = 1;
        map[14, 0] = 1;
        map[14, 3] = 1;
        map[14, 5] = 1;
        map[14, 9] = 1;
        map[14, 10] = 1;
        map[14, 13] = 1;

        print("XXXXXXXXXXXXXXXXXXXXX" + map[8, 7]);

    }
    public bool IsOkToMove(int row, int col, int dir)
    {
        print("222==========" + map[8, 7]);
        for (int i = 0; i < 15; i++)
        {
            print("22");
            for (int j = 0; j < 15; j++)
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
            if (row + 1 <= 14 && map[row + 1, col] == 0)
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
            if (col + 1 <= 14 && map[row, col + 1] == 0)
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
}*/




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class Map15x15 : MonoBehaviour
{

    int[,] map = new int[15, 15];
    // Use this for initialization
    public void Start()
    {

    }
    public void PP()
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                map[i, j] = 0;
            }
        }
        map[0, 1] = 1;
        map[0, 4] = 1;
        map[0, 6] = 1;
        map[0, 8] = 1;
        map[0, 11] = 1;
        map[0, 14] = 1;
        map[1, 2] = 1;
        map[1, 3] = 1;
        map[1, 5] = 1;
        map[1, 7] = 1;
        map[1, 8] = 1;
        map[1, 10] = 1;
        map[1, 12] = 1;
        map[2, 0] = 1;
        map[2, 2] = 1;
        map[2, 6] = 1;
        map[2, 11] = 1;
        map[2, 13] = 1;
        map[3, 2] = 1;
        map[3, 4] = 1;
        map[3, 6] = 1;
        map[3, 7] = 1;
        map[3, 9] = 1;
        map[3, 10] = 1;
        map[3, 11] = 1;
        map[3, 12] = 1;
        map[3, 14] = 1;
        map[4, 0] = 1;
        map[4, 1] = 1;
        map[4, 3] = 1;
        map[4, 6] = 1;
        map[4, 8] = 1;
        map[4, 12] = 1;
        map[5, 0] = 1;
        map[5, 4] = 1;
        map[5, 5] = 1;
        map[5, 7] = 1;
        map[5, 9] = 1;
        map[5, 11] = 1;
        map[5, 13] = 1;
        map[6, 2] = 1;
        map[6, 7] = 1;
        map[6, 9] = 1;
        map[6, 10] = 1;
        map[6, 14] = 1;
        map[7, 1] = 1;
        map[7, 3] = 1;
        map[7, 5] = 1;
        map[7, 6] = 1;
        map[7, 8] = 1;
        map[7, 10] = 1;
        map[7, 12] = 1;
        map[7, 13] = 1;
        map[8, 5] = 1;
        map[8, 7] = 1;
        map[8, 8] = 1;
        map[8, 11] = 1;
        map[8, 14] = 1;
        map[9, 0] = 1;
        map[9, 2] = 1;
        map[9, 3] = 1;
        map[9, 4] = 1;
        map[9, 6] = 1;
        map[9, 8] = 1;
        map[9, 10] = 1;
        map[9, 12] = 1;
        map[10, 1] = 1;
        map[10, 5] = 1;
        map[10, 9] = 1;
        map[10, 10] = 1;
        map[10, 13] = 1;
        map[11, 0] = 1;
        map[11, 2] = 1;
        map[11, 4] = 1;
        map[11, 6] = 1;
        map[11, 7] = 1;
        map[11, 9] = 1;
        map[11, 11] = 1;
        map[11, 14] = 1;
        map[12, 0] = 1;
        map[12, 2] = 1;
        map[12, 3] = 1;
        map[12, 4] = 1;
        map[12, 7] = 1;
        map[12, 8] = 1;
        map[12, 10] = 1;
        map[12, 12] = 1;
        map[12, 13] = 1;
        map[13, 1] = 1;
        map[13, 6] = 1;
        map[13, 11] = 1;
        map[13, 14] = 1;
        map[14, 0] = 1;
        map[14, 3] = 1;
        map[14, 5] = 1;
        map[14, 9] = 1;
        map[14, 10] = 1;
        map[14, 13] = 1;

        print("XXXXXXXXXXXXXXXXXXXXX" + map[8, 7]);

    }
    public bool IsOkToMove(int row, int col, int dir)
    {
        print("222==========" + map[8, 7]);
        for (int i = 0; i < 15; i++)
        {
            print("22");
            for (int j = 0; j < 15; j++)
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
            if (row + 1 <= 14 && map[row + 1, col] == 0)
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
            if (col + 1 <= 14 && map[row, col + 1] == 0)
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