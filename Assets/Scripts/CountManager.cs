using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountManager : MonoBehaviour
{
    private int count;

    void Start()
    {
        count = 0;
    }

    public void IncreaseCount()
    {
        count++;
        if (count >= 6)
        {
            Debug.Log("You Win!");
        }
    }

    public void DecreaseCount()
    {
        count--;
    }
}
