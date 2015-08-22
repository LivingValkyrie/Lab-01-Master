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

    static string assetsLocation = Application.dataPath;

    #endregion
    
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
        File.WriteAllText(assetsLocation + "/Materials/folderStructure.txt", "This folder is for storing materials.");
        File.WriteAllText(assetsLocation + "/Textures/folderStructure.txt", "This folder is for storing textures.");
        File.WriteAllText(assetsLocation + "/Prefabs/folderStructure.txt", "This folder is for storing prefabs.");
        File.WriteAllText(assetsLocation + "/Scripts/folderStructure.txt", "This folder is for storing scripts.");
        File.WriteAllText(assetsLocation + "/Scenes/folderStructure.txt", "This folder is for storing scenes.");
        File.WriteAllText(assetsLocation + "/Animations/folderStructure.txt", "This folder is for storing raw animations.");
        File.WriteAllText(assetsLocation + "/Animations/AnimationControllers/folderStructure.txt",
                          "This folder is for storing animations.");
    }

    [MenuItem("PreProcessor/Generate Folder Structure")]
    static void GenerateStructure() {
        
    }

}