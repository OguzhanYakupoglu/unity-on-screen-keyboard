using TMPro;
using UnityEngine;
public class SpaceKey : Key
{
    public override void Press()
    {
        // Add a space character to the target input field
        OnScreenKeyboard.Instance.TargetInput.text += " ";
    }
}
