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
        if (!Directory.Exists(assetsLocation + "/Dynamic")) {
            AssetDatabase.CreateFolder("Assets", "Dynamic");
        }
        if (!Directory.Exists(assetsLocation + "/Editor")) {
            AssetDatabase.CreateFolder("Assets", "Editor");
        }
        if (!Directory.Exists(assetsLocation + "/Extentions")) {
            AssetDatabase.CreateFolder("Assets", "Extentions");
        }
        if (!Directory.Exists(assetsLocation + "/_Scripts")) {
            AssetDatabase.CreateFolder("Assets", "_Scripts");
        }
        if (!Directory.Exists(assetsLocation + "/Plugins")) {
            AssetDatabase.CreateFolder("Assets", "Plugins");
        }
        if (!Directory.Exists(assetsLocation + "/Gizmos")) {
            AssetDatabase.CreateFolder("Assets", "Gizmos");
        }
        if (!Directory.Exists(assetsLocation + "/Shaders")) {
            AssetDatabase.CreateFolder("Assets", "Shaders");
        }
        if (!Directory.Exists(assetsLocation + "/Static")) {
            AssetDatabase.CreateFolder("Assets", "Static");
        }
        if (!Directory.Exists(assetsLocation + "/Testing")) {
            AssetDatabase.CreateFolder("Assets", "Testing");
        }
    }

    public static void GenerateFoldersSecondLevel() {
        if (!Directory.Exists(assetsLocation + "/_Scripts/Common")) {
            AssetDatabase.CreateFolder("Assets/_Scripts", "Common");
        }

        //dynamic folder
        if (!Directory.Exists(assetsLocation + "/Dynamic/Animations")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Animations");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/AnimationControllers")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "AnimationControllers");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Effects")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Effects");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Models")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Models");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Prefabs")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Prefabs");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Sounds")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Sounds");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Textures")) {
            AssetDatabase.CreateFolder("Assets/Dynamic", "Textures");
        }

        //static folder
        if (!Directory.Exists(assetsLocation + "/Static/Animations")) {
            AssetDatabase.CreateFolder("Assets/Static", "Animations");
        }
        if (!Directory.Exists(assetsLocation + "/Static/AnimationControllers")) {
            AssetDatabase.CreateFolder("Assets/Static", "AnimationControllers");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Effects")) {
            AssetDatabase.CreateFolder("Assets/Static", "Effects");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Models")) {
            AssetDatabase.CreateFolder("Assets/Static", "Models");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Prefabs")) {
            AssetDatabase.CreateFolder("Assets/Static", "Prefabs");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Sounds")) {
            AssetDatabase.CreateFolder("Assets/Static", "Sounds");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Textures")) {
            AssetDatabase.CreateFolder("Assets/Static", "Textures");
        }
    }

    public static void GenerateFoldersThirdLevel() {
        if (!Directory.Exists(assetsLocation + "/Dynamic/Animations/Sources")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Animations", "Sources");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Animations/Sources")) {
            AssetDatabase.CreateFolder("Assets/Static/Animations", "Sources");
        }

        if (!Directory.Exists(assetsLocation + "/Dynamic/Models/Character")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Models", "Character");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Models/Character")) {
            AssetDatabase.CreateFolder("Assets/Static/Models", "Character");
        }

        if (!Directory.Exists(assetsLocation + "/Dynamic/Models/Environment")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Models", "Environment");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Models/Environment")) {
            AssetDatabase.CreateFolder("Assets/Static/Models", "Environment");
        }

        if (!Directory.Exists(assetsLocation + "/Dynamic/Prefabs/Common")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Prefabs", "Common");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Prefabs/Common")) {
            AssetDatabase.CreateFolder("Assets/Static/Prefabs", "Common");
        }

        if (!Directory.Exists(assetsLocation + "/Dynamic/Sounds/Music")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Sounds", "Music");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Sounds/Music")) {
            AssetDatabase.CreateFolder("Assets/Static/Sounds", "Music");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Sounds/SFX")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Sounds", "SFX");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Sounds/SFX")) {
            AssetDatabase.CreateFolder("Assets/Static/Sounds", "SFX");
        }

        if (!Directory.Exists(assetsLocation + "/Dynamic/Textures/Common")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Textures", "Common");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Textures/Common")) {
            AssetDatabase.CreateFolder("Assets/Static/Textures", "Common");
        }
    }

    public static void GenerateFoldersForthLevel() {
        if (!Directory.Exists(assetsLocation + "/Dynamic/Sounds/Music/Common")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Sounds/Music", "Common");
        }
        if (!Directory.Exists(assetsLocation + "/Dynamic/Sounds/SFX/Common")) {
            AssetDatabase.CreateFolder("Assets/Dynamic/Sounds/SFX", "Common");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Sounds/Music/Common")) {
            AssetDatabase.CreateFolder("Assets/Static/Sounds/Music", "Common");
        }
        if (!Directory.Exists(assetsLocation + "/Static/Sounds/SFX/Common")) {
            AssetDatabase.CreateFolder("Assets/Static/Sounds/SFX", "Common");
        }
    }

    static void GenerateFiles() {
        Debug.Log("generating files");
        File.WriteAllText(assetsLocation + "/FolderStructure.txt", "This is the root of the folder structure");
        File.WriteAllText(assetsLocation + "/Dynamic/FolderStructure.txt", "This Folder is for dynamic assets");
        File.WriteAllText(assetsLocation + "/_Scripts/FolderStructure.txt", "This Folder is for Scripts");
        File.WriteAllText(assetsLocation + "/Shaders/FolderStructure.txt", "This Folder is for Shaders");
        File.WriteAllText(assetsLocation + "/Plugins/FolderStructure.txt", "This Folder is for plugins");
        File.WriteAllText(assetsLocation + "/Gizmos/FolderStructure.txt", "This Folder is for gizmo scripts");
        File.WriteAllText(assetsLocation + "/Extentions/FolderStructure.txt", "This Folder is for extentions");
        File.WriteAllText(assetsLocation + "/Editor/FolderStructure.txt", "This Folder is for Editor scripts");
        File.WriteAllText(assetsLocation + "/Testing/FolderStructure.txt", "This Folder is for testing/placeholder assets");
        File.WriteAllText(assetsLocation + "/Static/FolderStructure.txt", "This Folder is for dynamic assets");
    }

    [MenuItem("PreProcessor/Generate Folder Structure")]
    static void GenerateStructure() {
        GenerateFolders();
        GenerateFoldersSecondLevel();
        GenerateFoldersThirdLevel();
        GenerateFoldersForthLevel();
        GenerateFiles();
        AssetDatabase.Refresh();
    }
}