using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "Keyboard Settings", menuName = "Keyboard Settings")]
public class KeyboardSettings : ScriptableObject
{
    [Header("Repeat Press Settings")]
    public float initialRepeatDelay = 0.5f;
    public float minRepeatDelay = 0.05f;
    public float repeatAcceleration = 0.05f;

    [Header("Visual Settings")]
    public TMP_FontAsset keyFont;
    public Color keyboardColor = Color.gray;
    public Color keyColor = Color.gray;
    public Color keyInnerColor = Color.white;
    public Color pressedKeyColor = Color.white;
    public Color pressedInnerKeyColor = Color.black;
}