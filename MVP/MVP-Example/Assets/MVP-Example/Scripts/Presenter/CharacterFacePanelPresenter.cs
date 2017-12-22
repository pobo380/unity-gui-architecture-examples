using UniRx;
using UnityEngine;

public class CharacterFacePanelPresenter
{
    // properties

    private CharacterFacePanelView _view;
    private DeckModel _model;
    private int _index;

    // public methods

    public CharacterFacePanelPresenter(CharacterFacePanelView view, DeckModel model)
    {
        _view = view;
        _model = model;
    }

    public void Setup(int index)
    {
        _index = index;
        _model.CharacterIDs.ObserveReplace().Where(prop => prop.Index == _index).Subscribe(prop => ReplaceCharacter(prop));
        _view.OnClick = SelectCharacter;
    }

    // private methods

    private void SelectCharacter()
    {
        _model.SelectCharacter(_index);
    }

    private void ReplaceCharacter(CollectionReplaceEvent<int> prop)
    {
        int charId = prop.NewValue;

        Sprite sprite;
        if (!CharacterFaceSpriteProvider.Instance.TryGetSprite(charId, out sprite))
        {
            return;
        }

        Character data;
        if (!CharacterMasterDataProvider.Instance.TryGetData(charId, out data))
        {
            return;
        }

        Color color;
        if (!ElementFrameColorProvider.Instance.TryGetColor(data.ElementType, out color))
        {
            return;
        }

        _view.SetCharacterFace(sprite);
        _view.SetElementFrame(color);
    }
}