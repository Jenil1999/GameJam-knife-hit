using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CbRotate : MonoBehaviour
{
    public GameObject cardBoard;
    public float rPm = 10;

    public void Update()
    {
        cardBoard.transform.Rotate(0, 0, 6f * rPm);
    }
}
