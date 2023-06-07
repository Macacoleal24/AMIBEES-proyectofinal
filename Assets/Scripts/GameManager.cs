using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int TotalHoney { get { return totalHony; } }

    private int totalHony; 

    public void AddPoints(int addtopoints)
    {
        totalHony += addtopoints;
        Debug.Log(totalHony);
    }
}
