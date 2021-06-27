using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CanEditMultipleObjects]
[CustomEditor(typeof(ColorPropagator))]
public class ColorPropagatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("Propogate"))
        {
            foreach (object o in targets)
            {
                ColorPropagator cp = (ColorPropagator)o;
                cp.propogate();
            }
        }
    }
}
