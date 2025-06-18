using System.Collections;
using UnityEngine;

public class KeyboardToggleKey : Key
{
    [SerializeField] KeyboardType targetKeyboard;
    public override void Press()
    {
        StartCoroutine(DelayedSwitch());
    }
    private IEnumerator DelayedSwitch()
    {
        yield return null;
        SetNormalColor();
        OnScreenKeyboard.Instance.OpenKeyboard(targetKeyboard);
    }
}
