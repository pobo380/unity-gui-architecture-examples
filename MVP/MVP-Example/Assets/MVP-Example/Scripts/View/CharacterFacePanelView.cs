using System;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CharacterFacePanelView : MonoBehaviour
{
    // properties

    [SerializeField]
    private Image _characterFace;

    [SerializeField]
    private Image _elementFrame;

    [SerializeField]
    private Button _button;

    public Action OnClick = delegate { };

    // public methods

    public void Setup()
    {
        _button.onClick.AddListener(ButtonOnClick);
    }

    public void SetCharacterFace(Sprite sprite)
    {
        _characterFace.sprite = sprite;
    }

    public void SetElementFrame(Color color)
    {
        _elementFrame.color = color;
    }

    public void Hoge()
    {
        ButtonOnClick();
    }

    // private methods

    private void ButtonOnClick()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }
}
