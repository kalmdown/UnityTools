using UnityEditor;


[CustomEditor(typeof(ObjectsRing)), CanEditMultipleObjects]
public class ObjectsRingEditor : Editor
{
    private SerializedProperty radiusProperty;
    private SerializedProperty beginAngleProperty;
    private SerializedProperty endAngleProperty;
    private SerializedProperty flipProperty;
    private SerializedProperty orientationProperty;

    public void OnEnable()
    {
        radiusProperty = serializedObject.FindProperty("radius");
        beginAngleProperty = serializedObject.FindProperty("beginAngle");
        endAngleProperty = serializedObject.FindProperty("endAngle");
        flipProperty = serializedObject.FindProperty("flip");
        orientationProperty = serializedObject.FindProperty("orientation");
    }
    
    
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        radiusProperty.floatValue = EditorGUILayout.Slider ("Radius", radiusProperty.floatValue, 0, 100);
        beginAngleProperty.floatValue = EditorGUILayout.Slider ("Begin Angle", beginAngleProperty.floatValue, 0, 360);
        endAngleProperty.floatValue = EditorGUILayout.Slider ("End Angle", endAngleProperty.floatValue, 0, 360);
        flipProperty.boolValue = EditorGUILayout.Toggle ("Flip", flipProperty.boolValue);
        orientationProperty.enumValueIndex = EditorGUILayout.Popup ("Orientation", orientationProperty.enumValueIndex, orientationProperty.enumDisplayNames);

        serializedObject.ApplyModifiedProperties();
        EditorApplication.update.Invoke();
    }
}
