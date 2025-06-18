using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum KeyboardType { Alphabet, Numeric, Symbol }
[System.Serializable]
public class KeyboardSet
{
    public KeyboardType keyboardType;
    public GameObject keyboard;
}
public class OnScreenKeyboard : MonoBehaviour
{
    public static OnScreenKeyboard Instance { get; private set; }
    [SerializeField] private TMP_InputField targetInput;
    public TMP_InputField TargetInput { get => targetInput; }


    public bool IsUpperCase { get; private set; }
    public System.Action OnUpperCaseToggle;
    [SerializeField] private Image keyboardImage;
    public KeyboardSettings keyboardSettings;


    [Header("Keyboards")]
    [SerializeField] private KeyboardSet alphabetSet;
    [SerializeField] private KeyboardSet numberSet;
    [SerializeField] private KeyboardSet symbolSet;
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    void Start()
    {
        OpenKeyboard(KeyboardType.Alphabet);
        keyboardImage.color = keyboardSettings.keyboardColor;
    }

    public void ToggleCase()
    {
        IsUpperCase = !IsUpperCase;
        OnUpperCaseToggle?.Invoke();
    }
    public void OpenKeyboard(KeyboardType targetKeyboardType)
    {
        alphabetSet.keyboard.SetActive(alphabetSet.keyboardType == targetKeyboardType);
        numberSet.keyboard.SetActive(numberSet.keyboardType == targetKeyboardType);
        symbolSet.keyboard.SetActive(symbolSet.keyboardType == targetKeyboardType);
    }
}
