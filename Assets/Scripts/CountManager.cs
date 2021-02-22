using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    private int count;
    public Text winText;

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
            winText.gameObject.SetActive(true);
        }
    }

    public void DecreaseCount()
    {
        count--;
    }
}
