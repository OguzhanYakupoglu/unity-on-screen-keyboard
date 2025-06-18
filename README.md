# On-Screen Keyboard for Unity 

A responsive and modular on-screen keyboard built for Unity UI.  
Supports uppercase toggle, symbol/numeric modes, and customizable key appearance.


## How to Use

1. **Download or clone this repository.**

2. **Copy the On Screen Keyboard/ folder into your Unity project's Assets/ folder.**

3. Drag the **On-Screen-Keyboard-(Landscape or Portrait) prefab** into your Canvas.

4. Create a TMP_InputField (TextMeshPro) and assign it to the **Target Input** field on the OnScreenKeyboard component.


## Customizing Appearance

1. Right-click in the KeyboardSettings folder →  
    Create > Keyboard Settings

2. Assign the new KeyboardSettings asset to the OnScreenKeyboard component.

3. You can configure:
   - Background color of keys
   - Text color
   - Pressed state colors
   - Fonts (TextMeshPro)


## Flexibility

- The keyboard system is built with modularity in mind.
- You can easily swap out TMP_InputField for your own input system — just update the logic in the Key subclasses.
- Similarly, you can replace the TextMeshProUGUI fields with standard Unity Text components if you don’t use TextMeshPro.


## Example

Check the Demo/ folder for a working scene setup.
