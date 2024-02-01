using Lesson_3.Scripts.FactoryExample.Images;
using UnityEditor;
using UnityEngine;

namespace Lesson_3.Scripts.Editor.FactoryExample
{
    [CustomPropertyDrawer(typeof(ImageIdAttribute))]
    public class ImageIdAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var ids = ImagesDefinitions.I.IDs;

            var index = Mathf.Max(ids.IndexOf(property.stringValue), 0);
            index = EditorGUI.Popup(position, property.displayName, index, ids.ToArray());
            property.stringValue = ids[index];
        }
    }
}