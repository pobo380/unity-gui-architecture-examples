using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CharacterSelectIndicatorView : MonoBehaviour
{
    // properties

    [SerializeField]
    private Image _overlay;

    // public methods

    public void Setup()
    {
        _overlay.gameObject.SetActive(false);
    }

    public void SetVisible(bool visible)
    {
        _overlay.gameObject.SetActive(visible);
    }
}
