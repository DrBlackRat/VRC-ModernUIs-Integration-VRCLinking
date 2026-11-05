using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEditor;

namespace DrBlackRat.VRC.ModernUIs.Integrations.Editor
{
    public static class ModernUIsIntegrationsVRCLinkingMenu
    {
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/VRCLinking/Add VRCLinking to Whitelist Bridge Prefab to Scene", false, 2)]
        public static void AddPrefab()
        {
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Packages/xyz.drblackrat.vrc.modernuis.integrations.vrclinking/Runtime/Prefabs/VRCLinking To Whitelist Bridge.prefab");
            PrefabUtility.InstantiatePrefab(prefab);
        }
        
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/VRCLinking/Show ReadMe", false, 3)]
        public static void ShowReadMe()
        {
            PingAsset("Packages/xyz.drblackrat.vrc.modernuis.integrations.vrclinking/README.md");
        }
        
        [MenuItem("Tools/DrBlackRat/ModernUIs Integrations/VRCLinking/Open GitHub", false, 4)]
        public static void OpenGitHub()
        {
            Application.OpenURL("https://github.com/DrBlackRat/VRC-ModernUIs-Integration-VRCLinking");
        }
        
        private static void PingAsset(string path)
        {
            var folder = AssetDatabase.LoadAssetAtPath<Object>(path);

            if (folder != null)
            {
                Selection.activeObject = folder;
                EditorGUIUtility.PingObject(folder);
            }
        }
    }
}
