﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRenderer : MonoBehaviour
{
    void OnRenderObject()
    {


        Scanner.material.SetPass(0);
        Graphics.DrawProceduralNow(MeshTopology.Points, Scanner.pointCount);
    }
}