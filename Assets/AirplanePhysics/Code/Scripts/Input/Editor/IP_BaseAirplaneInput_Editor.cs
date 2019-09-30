using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

namespace IndiePixel
{
    [CustomEditor(typeof(IP_BaseAirplane_Input))]
    public class IP_BaseAirplaneInput_Editor : Editor
    {
        #region Variables
        private IP_BaseAirplane_Input targetInput;
        #endregion

        #region Builtin Methods
        private void OnEnable()
        {
            targetInput = (IP_BaseAirplane_Input)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            StringBuilder debugInfo = new StringBuilder();
            debugInfo.AppendLine(string.Format("Pitch = {0}", targetInput.Pitch));
            debugInfo.AppendLine(string.Format("Roll = {0}", targetInput.Roll));
            debugInfo.AppendLine(string.Format("Yaw = {0}", targetInput.Yaw));
            debugInfo.AppendLine(string.Format("Throttle = {0}", targetInput.Throttle));
            debugInfo.AppendLine(string.Format("Brake = {0}", targetInput.Brake));
            debugInfo.AppendLine(string.Format("Flaps = {0}", targetInput.Flaps));

            //custon editor code
            GUILayout.Space(20);
            EditorGUILayout.TextArea(debugInfo.ToString(), GUILayout.Height(100));
            GUILayout.Space(20);

            Repaint();

        }
        #endregion
    }
}
