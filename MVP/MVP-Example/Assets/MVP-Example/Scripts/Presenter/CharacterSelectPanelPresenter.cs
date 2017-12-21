using UnityEngine;

public class CharacterSelectPanelPresenter
{
    // properties

    private CharacterSelectPanelView _view;
    private Character _characterMasterData;

    // public methods

    public CharacterSelectPanelPresenter(CharacterSelectPanelView view, Character characterMasterData)
    {
        _view = view;
        _characterMasterData = characterMasterData;
    }

    public void Setup()
    {
        RefreshView();
    }

    // private method

    public void RefreshView()
    {
        _view.SetNameText(_characterMasterData.Name.ToString());
        _view.SetHPText(_characterMasterData.HP.ToString());
        _view.SetPowerText(_characterMasterData.Power.ToString());
        _view.SetSpeedText(_characterMasterData.Speed.ToString());

        Sprite faceSprite;
        if (CharacterFaceSpriteProvider.Instance.TryGetSprite(_characterMasterData.ID, out faceSprite))
        {
            _view.FacePanel.SetCharacterFace(faceSprite);
        }

        Color elementColor;
        if (ElementFrameColorProvider.Instance.TryGetColor(_characterMasterData.ElementType, out elementColor))
        {
            _view.FacePanel.SetElementFrame(elementColor);
        }
    }
}
