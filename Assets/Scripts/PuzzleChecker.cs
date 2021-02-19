using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleChecker : MonoBehaviour
{
    public Piece piece;
    private int count = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piece"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, piece.gameObject))
            {
                count = count + 1;
                if (count == 6)
                {
                    Debug.Log("You win!");
                }
                Debug.Log(count);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Piece"))
        {
            count = count - 1;
            Debug.Log("You removed a piece");
        }
    }
}
