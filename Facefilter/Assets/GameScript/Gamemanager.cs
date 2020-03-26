using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("id", i);
    }


    public void nextimage()
    {
        i++;
        if(i>3)
        {
            i = 0;
        }
        PlayerPrefs.SetInt("id", i);
    }
 
}
