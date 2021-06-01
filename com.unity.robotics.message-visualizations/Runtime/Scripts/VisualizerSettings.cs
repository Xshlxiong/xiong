using System.IO;
using System.Collections;
using Unity.Robotics.ROSTCPConnector;
using UnityEngine;
using UnityEditor;

namespace Unity.Robotics.MessageVisualizers
{
    public class VisualizerSettings : MonoBehaviour, IHudTab
    {
        string IHudTab.Label => "Settings";
        string m_LayoutPath;

        IEnumerator Start()
        {
            // Add settings to HUD after other tabs registered
            yield return new WaitForEndOfFrame();
            HUDPanel.RegisterTab(this);
        }

        void IHudTab.OnGUI(HUDPanel hud) 
        { 
            // Save/Load layout files
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Export layout"))
            {
                m_LayoutPath = EditorUtility.SaveFilePanel("Save Visualizations Settings", "", "RosHudLayout", "json");
                hud.SaveLayout(m_LayoutPath);
            }
            if (GUILayout.Button("Import layout"))
            {
                m_LayoutPath = EditorUtility.OpenFilePanel("Select Visualizations Settings", "", "json");
                hud.LoadLayout(m_LayoutPath);
            }
            GUILayout.EndHorizontal();
        }

        void IHudTab.OnSelected() { }
        void IHudTab.OnDeselected() { }
    }
}
