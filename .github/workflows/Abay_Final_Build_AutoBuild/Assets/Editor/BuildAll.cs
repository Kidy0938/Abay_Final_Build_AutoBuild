using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildAll {
    [MenuItem("Tools/Build/Build All")]
    public static void BuildEverything() {
        string buildPath = "Builds";
        if (!Directory.Exists(buildPath)) Directory.CreateDirectory(buildPath);

        string[] scenes = {
            "Assets/Scenes/MainMenu.unity",
            "Assets/Scenes/DemoBattle.unity",
            "Assets/Scenes/Lobby.unity"
        };

        // Build PC EXE
        string pcPath = Path.Combine(buildPath, "PC");
        if (!Directory.Exists(pcPath)) Directory.CreateDirectory(pcPath);
        BuildPipeline.BuildPlayer(scenes, Path.Combine(pcPath, "Abay.exe"), BuildTarget.StandaloneWindows64, BuildOptions.None);

        // Build Android APK
        string androidPath = Path.Combine(buildPath, "Android");
        if (!Directory.Exists(androidPath)) Directory.CreateDirectory(androidPath);
        BuildPipeline.BuildPlayer(scenes, Path.Combine(androidPath, "Abay.apk"), BuildTarget.Android, BuildOptions.None);

        Debug.Log("Builds completed: PC and Android");
    }
}