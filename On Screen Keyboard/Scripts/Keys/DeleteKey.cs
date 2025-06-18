using UnityEngine;
using UnityEngine.UI;

public class DeleteKey : Key
{
    public override void Press()
    {
        var inputField = OnScreenKeyboard.Instance.TargetInput;

        // Remove the last character from the input field's text
        if (!string.IsNullOrEmpty(inputField.text))
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
    }
}
