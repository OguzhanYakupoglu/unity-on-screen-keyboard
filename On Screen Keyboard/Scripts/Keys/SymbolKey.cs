using TMPro;
using UnityEngine;

public class SymbolKey : Key
{
    [SerializeField] private string keyValue;
    [SerializeField] private TextMeshProUGUI keyTMP => keyInner as TextMeshProUGUI;

    protected override void Start()
    {
        base.Start();
        keyTMP.text = keyValue;
    }
    public override void Press()
    {
        OnScreenKeyboard.Instance.TargetInput.text += keyValue;
    }
}
