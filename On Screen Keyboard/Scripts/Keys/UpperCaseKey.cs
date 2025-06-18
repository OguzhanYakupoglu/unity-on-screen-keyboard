using UnityEngine;
using UnityEngine.UI;
public class UpperCaseKey : Key
{
    [SerializeField] private Image upperCaseImage;
    [SerializeField] private Sprite upperCaseOnSprite, upperCaseOffSprite;
    protected override void Start()
    {
        base.Start();
        SetSprite();
        OnScreenKeyboard.Instance.OnUpperCaseToggle += SetSprite;
    }
    public override void Press()
    {
        // Toggle the keyboard to uppercase mode
        OnScreenKeyboard.Instance.ToggleCase();
    }
    private void SetSprite()
    {
        if (upperCaseImage != null)
        {
            upperCaseImage.sprite = OnScreenKeyboard.Instance.IsUpperCase ? upperCaseOnSprite : upperCaseOffSprite;
        }
    }
}
