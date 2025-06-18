using TMPro;
using UnityEngine;

public class ReturnKey : Key
{
    public override void Press()
    {
        // Simulate pressing the return key by adding a newline character
        OnScreenKeyboard.Instance.TargetInput.text += "\n";
    }
}
