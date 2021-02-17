using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleChecker : MonoBehaviour
{
    public Piece piece;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piece"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, piece.gameObject))
            {
                Debug.Log("You did it.");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Piece"))
        {
            Debug.log("You removed a piece");
        }
    }
}
