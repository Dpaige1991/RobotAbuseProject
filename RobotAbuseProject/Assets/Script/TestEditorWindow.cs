using UnityEngine;
using UnityEditor;

public class TestEditorWindow : EditorWindow
{
    [MenuItem("Window/Test")]
    public static void ShowWindow()
    {
        GetWindow<TestEditorWindow>("Test Project");
    }

    private void OnGUI()
    {
        GUILayout.Label("Test Project", EditorStyles.boldLabel);

        if(GUILayout.Button("Test"))
        {
            TestProject();
        }
    }

    void TestProject()
    {
        foreach(GameObject obj in Selection.gameObjects)
        {
            var check = obj.GetComponent<Attachments>();

            if (check.leftArmAttached == true && check.rightArmAttached == true)
            {
                Debug.Log("Successful");
            }
            else if (check.leftArmAttached == false && check.rightArmAttached == true)
            {
                Debug.LogError("Failed: Left Arm Is Not Attached");
            }
            else if (check.leftArmAttached == true && check.rightArmAttached == false)
            {
                Debug.LogError("Failed: Right Arm Is Not Attached");
            }
        }
    }
}
