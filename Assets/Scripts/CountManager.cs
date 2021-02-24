using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountManager : MonoBehaviour
{
    private int count;
    public Text winText;
    public GameObject winningMap;
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;

    void Start()
    {
        count = 0;
    }

    public void IncreaseCount()
    {
        count++;
        Debug.Log(count);
        if (count >= 6)
        {
            Debug.Log("You Win!");
            winText.gameObject.SetActive(true);
            winningMap.gameObject.SetActive(true);
            piece1.gameObject.SetActive(false);
            piece2.gameObject.SetActive(false);
            piece3.gameObject.SetActive(false);
            piece4.gameObject.SetActive(false);
            piece5.gameObject.SetActive(false);
            piece6.gameObject.SetActive(false);
        }
    }

    public void DecreaseCount()
    {
        count--;
        Debug.Log(count);
    }
}
