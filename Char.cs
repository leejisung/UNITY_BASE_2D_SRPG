using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    float X_base = -11.5f;
    float Y_base = -3.5f;

    public int Move_point = 5;
    public float X_switch = 0;
    public float Y_switch = 0;

    // Start is called before the first frame update

    void move_area(int X, int Y, int mp)
    {
        if (mp== Move_point)
        {
            for (int x = 0; x < 29; x++)
            {
                for (int y = 0; y < 29; y++)
                {
                    GameManager.Instance.BLUE_ARR[x, y] = 0;
                }
            }
        }
        if (mp<0 || X<0 || Y<0 || GameManager.Instance.ARR[X,Y]!=0)
        {
            return;
        }
        if (GameManager.Instance.BLUE_ARR[X, Y] == 0 && ((X == (int)X_switch) && (Y == (int)Y_switch))==false )
        {
            GameManager.Instance.BLUE_ARR[X, Y] = 1;
        }
        move_area(X + 1, Y, mp - 1);
        move_area(X - 1, Y, mp - 1);
        move_area(X, Y + 1, mp - 1);
        move_area(X, Y - 1, mp - 1);
    }
    void OnMouseDown()
    {
        Debug.Log("rehu");
        move_area((int)X_switch, (int)Y_switch, Move_point);
        
    }
    void Start()
    {
        transform.position = new Vector3(X_base+X_switch, Y_base+Y_switch,-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
