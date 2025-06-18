using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using TMPro;

// This class serves as a base class for all keys in the on-screen keyboard.
public abstract class Key : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Coroutine for handling repeated key presses
    // This coroutine will be started when the key is pressed and will continue to call Press() at intervals.
    private Coroutine _repeatCoroutine;
    private Image _keyImage;
    protected Graphic keyInner;
    protected virtual void Awake()
    {
        _keyImage = GetComponent<Image>();
        if (_keyImage == null)
            Debug.LogError("Key component requires an Image component for visual feedback.");

        keyInner = transform.GetChild(0).GetComponent<Graphic>();
        if (keyInner == null)
            Debug.LogError("Requires a child graphic object for for visual feedback.");


    }
    protected virtual void Start()
    {
        if (keyInner.TryGetComponent<TextMeshProUGUI>(out var tmp))
        {
            tmp.font = OnScreenKeyboard.Instance.keyboardSettings.keyFont;
        }
        SetNormalColor();
    }
    public abstract void Press();
    public void OnPointerDown(PointerEventData eventData)
    {
        Press();
        SetPressColor();

        if (_repeatCoroutine == null && gameObject.activeInHierarchy)
            _repeatCoroutine = StartCoroutine(RepeatPress());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        SetNormalColor();

        if (_repeatCoroutine != null)
        {
            StopCoroutine(_repeatCoroutine);
            _repeatCoroutine = null;
        }
    }

    private IEnumerator RepeatPress()
    {
        var keySettings = OnScreenKeyboard.Instance.keyboardSettings;
        float delay = keySettings.initialRepeatDelay;

        while (true)
        {
            yield return new WaitForSeconds(delay);
            Press();
            delay = Mathf.Max(keySettings.minRepeatDelay, delay - keySettings.repeatAcceleration);
        }
    }

    protected virtual void SetPressColor()
    {
        if (_keyImage != null)
        {
            _keyImage.color = OnScreenKeyboard.Instance.keyboardSettings.pressedKeyColor;
            keyInner.color = OnScreenKeyboard.Instance.keyboardSettings.pressedInnerKeyColor;
        }
    }
    protected virtual void SetNormalColor()
    {
        if (_keyImage != null)
        {
            _keyImage.color = OnScreenKeyboard.Instance.keyboardSettings.keyColor;
            keyInner.color = OnScreenKeyboard.Instance.keyboardSettings.keyInnerColor;
        }
    }
}
