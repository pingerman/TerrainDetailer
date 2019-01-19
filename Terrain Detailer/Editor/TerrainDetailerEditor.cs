namespace Pingerman.Tools.Terrain
{
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(TerrainDetailer))]
    public class TerrainDetailerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var terrainDetailer = (TerrainDetailer)target;

            var activated = serializedObject.FindProperty("activated");

            if (activated.boolValue)
            {
                if (GUILayout.Button("Detail: ON"))
                {
                    terrainDetailer.DetailOff();
                }
            }
            else
            {
                if (GUILayout.Button("Detail: OFF"))
                {
                    terrainDetailer.DetailOn();
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}


