using UnityEngine;

public class CharacterSelectPanelPresenter
{
    // properties

    private CharacterSelectPanelView _view;
    private Character _characterMasterData;
    private DeckModel _deckModel;

    // public methods

    public CharacterSelectPanelPresenter(CharacterSelectPanelView view, Character characterMasterData, DeckModel deckModel)
    {
        _view = view;
        _characterMasterData = characterMasterData;
        _deckModel = deckModel;
    }

    public void Setup()
    {
        SetupCharacterInfo();

        _view.OnClick = SelectPanelOnClick;
    }

    // private method

    private void SetupCharacterInfo()
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

    private void SelectPanelOnClick()
    {
        _deckModel.SetCharacter(_characterMasterData.ID);
    }
}
