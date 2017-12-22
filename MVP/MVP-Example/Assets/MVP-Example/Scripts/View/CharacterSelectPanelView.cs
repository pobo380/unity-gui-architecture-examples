using System;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class CharacterSelectPanelView : MonoBehaviour
{
    // properties

    [SerializeField]
    private Text _nameText;

    [SerializeField]
    private Text _hpText;

    [SerializeField]
    private Text _powerText;

    [SerializeField]
    private Text _speedText;

    [SerializeField]
    private Button _selectButton;

    [SerializeField]
    private Transform _facePanelParent;

    [SerializeField]
    private CharacterFacePanelView _facePanelViewPrefab;

    public CharacterFacePanelView FacePanel
    {
        get;
        private set;
    }

    public Action OnClick = delegate { };

    // public methods

    public void Setup()
    {
        FacePanel = Instantiate(_facePanelViewPrefab, _facePanelParent, false);
        FacePanel.Setup();

        _selectButton.onClick.AddListener(SelectButtonOnClick);
    }

    public void SetNameText(string text)
    {
        _nameText.text = text;
    }

    public void SetHPText(string text)
    {
        _hpText.text = text;
    }

    public void SetPowerText(string text)
    {
        _powerText.text = text;
    }

    public void SetSpeedText(string text)
    {
        _speedText.text = text;
    }

    // private methods

    private void SelectButtonOnClick()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }
}
