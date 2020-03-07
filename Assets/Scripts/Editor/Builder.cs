﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Builder : MonoBehaviour
{
    private static Dictionary<string, Action<string>> actionsByParameters = new Dictionary<string, Action<string>>
    {
        {"targetPlatform", BuildFor},
        {"outputDir", SetOutputDir}
    };

    private static string outputDir;
    private static string targetPlatform;
    
    static public void PerformBuild()
    {
        var args = System.Environment.GetCommandLineArgs();
        foreach (var argument in args)
        {
            var nameValueArg = argument.Split(new[]{"="}, StringSplitOptions.RemoveEmptyEntries);
            actionsByParameters[nameValueArg[0]].Invoke(nameValueArg[1]);
        }
    }

    static public void BuildFor(string target)
    {
        BuildTarget buildTarget = (BuildTarget)Enum.Parse(typeof(BuildTarget), targetPlatform);
        BuildPipeline.BuildPlayer(new[] {"MenuPrincipal"}, outputDir, buildTarget, BuildOptions.None);
    }

    static public void SetOutputDir(string output)
    {
        outputDir = output;
    }
}