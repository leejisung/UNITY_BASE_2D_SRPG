using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    SpriteRenderer sr;
    float X_base = -11.5f;
    float Y_base = -3.5f;
    public int X;
    public int Y;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = new Color(1, 1, 1, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.BLUE_ARR[X,Y]==1)
        {
            sr.color = new Color(1, 1, 1, 0.5f);
        }
        else
        {
            sr.color = new Color(1, 1, 1, 0f);
        }
    }
}
