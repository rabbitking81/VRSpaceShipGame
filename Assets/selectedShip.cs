using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectedShip : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;

    // Start is called before the first frame update
    void Start()
    {
        int shipType = PlayerPrefs.GetInt("ShipType");

        if (shipType == 1)
        {
            ship01.SetActive(true);
        }
        else if(shipType == 2)
        {
            ship02.SetActive(true);
        } else
        {
            ship01.SetActive(true);
        }
    }
}
