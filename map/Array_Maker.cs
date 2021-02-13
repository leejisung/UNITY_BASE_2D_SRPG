using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Array_Maker : MonoBehaviour
{
    public GameObject can;
    float X_base = -11.5f;
    float Y_base = -3.5f;
    void Array_reset()
    {
        for (int x = 0; x < 29; x++)
        {
            for (int y = 0; y < 29; y++)
            {
                GameManager.Instance.ARR[x, y] = -1;
            }
        }
        Tilemap tilemap = GetComponent<Tilemap>();
        BoundsInt bounds = tilemap.cellBounds;
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);

        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                TileBase tile = allTiles[x + y * bounds.size.x];
                if (tile != null)
                {
                    GameManager.Instance.ARR[x, y] = 0;

                    GameManager.Instance.BLUE_ARR[x, y] = 0;
                    GameObject cell = Instantiate(can, new Vector3(X_base+x, Y_base+y, -1), Quaternion.identity);

                    cell.GetComponent<blue>().X = x;
                    cell.GetComponent<blue>().Y = y;
                }
            }
        }        
    }
    void Array_print()
    {
        Tilemap tilemap = GetComponent<Tilemap>();
        BoundsInt bounds = tilemap.cellBounds;
        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                Debug.Log("x:" + x + " y:" + y +" " + GameManager.Instance.ARR[x, y]) ;
            }
        }
    }
    void Start()
    {
        Array_reset();
        GameObject.Find("Tilemap_tree").GetComponent<array_tree>().make_tree_ARR();
    }
    void Update()
    {

    }
}
