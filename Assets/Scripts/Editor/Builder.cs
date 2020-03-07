using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    static public void PerformBuild()
    {
        var args = System.Environment.GetCommandLineArgs();
        foreach (var argument in args)
        {
            Debug.Log(argument);
        }
    }
}
