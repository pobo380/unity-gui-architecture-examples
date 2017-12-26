using System;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class FavoriteStarView : MonoBehaviour
{
    // properties

    [SerializeField]
    private Image _starImage;

    [SerializeField]
    private Button _button;

    public Action OnClick = delegate { };

    // public methods

    public void Setup()
    {
        _button.onClick.AddListener(ButtonOnClick);
        _starImage.gameObject.SetActive(false);
    }

    public void SetVisible(bool visible)
    {
        _starImage.gameObject.SetActive(visible);
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
