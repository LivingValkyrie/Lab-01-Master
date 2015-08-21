using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: PreProcessor 
/// </summary>
public class PreProcessor : MonoBehaviour {
    #region Fields

    string assetsLocation = Application.dataPath;

    #endregion

    [MenuItem("PreProcessor/Generate Folders")]
    public static void GenerateFolders() {
        AssetDatabase.CreateFolder("Assets", "Materials");
        AssetDatabase.CreateFolder("Assets", "Textures");
        AssetDatabase.CreateFolder("Assets", "Prefabs");
        AssetDatabase.CreateFolder("Assets", "Scripts");
        AssetDatabase.CreateFolder("Assets", "Scenes");
        AssetDatabase.CreateFolder("Assets", "Animations");
        AssetDatabase.CreateFolder("Assets/Animations", "AnimationControllers");
    }

    static void GenerateFiles() {
        using () {}
    }

}