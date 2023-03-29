using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textwin : MonoBehaviour
{
    public Text winner;
    void Start()
    {
        winner.text = Playing.winner;
    }
}
