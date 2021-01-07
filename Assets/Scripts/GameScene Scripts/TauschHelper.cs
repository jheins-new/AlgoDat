﻿using UnityEngine;
using System.Collections;

public static class TauschHelper
{

    public static void TauscheElement<T>(this System.Collections.Generic.IList<T> list, int p1, int p2)
    {
        T tmp = list[p1];
        list[p1] = list[p2];
        list[p2] = tmp;
    }
}
