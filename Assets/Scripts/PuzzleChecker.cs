using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleChecker : MonoBehaviour
{
    public Piece piece;
    public CountManager countManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piece"))
        {
            if (GameObject.ReferenceEquals(other.gameObject, piece.gameObject))
            {
                countManager.IncreaseCount();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Piece"))
        {
            countManager.DecreaseCount();
        }
    }
}
