using TMPro;
using UnityEngine;

public class AlphabetKey : Key
{
    [SerializeField] private string keyValue;
    [SerializeField] private TextMeshProUGUI keyTMP => keyInner as TextMeshProUGUI;

    protected override void Start()
    {
        base.Start();
        SetKeyText();
        OnScreenKeyboard.Instance.OnUpperCaseToggle += SetKeyText;
    }
    public override void Press()
    {
        OnScreenKeyboard.Instance.TargetInput.text += OnScreenKeyboard.Instance.IsUpperCase ? keyValue.ToUpper() : keyValue.ToLower();
    }
    private void SetKeyText()
    {
        keyTMP.text = OnScreenKeyboard.Instance.IsUpperCase ? keyValue.ToUpper() : keyValue.ToLower();
    }
}
