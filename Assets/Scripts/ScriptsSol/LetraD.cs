﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraD : MonoBehaviour
{
    bool iscolor = true;

    void OnMouseDown()
    {
        iscolor = !iscolor;
        if (iscolor)
        {
            //GetComponent<Renderer>().material.color = Color.cyan;

        }
        else
        {
            GetComponent<Renderer>().material.color = Color.magenta;
            CrearSol.scoreSol += "d";
        }
    }
}