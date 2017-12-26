using System;
using UniRx;
using UnityEngine;

public class FavoriteStarPresenter
{
    // properties

    private FavoriteStarView _view;
    private CharacterListModel _model;
    private int _index;

    // public methods

    public FavoriteStarPresenter(FavoriteStarView view, CharacterListModel model)
    {
        _view = view;
        _model = model;
    }

    public void Setup(int index)
    {
        _index = index;
        _view.OnClick = ButtonOnClick;
        _model.IsFavorite.ObserveReplace().Where(prop => prop.Index == _index).Subscribe(prop => RefreshView(prop));
    }

    // private methods

    private void RefreshView(CollectionReplaceEvent<bool> prop)
    {
        _view.SetVisible(prop.NewValue);
    }

    private void ButtonOnClick()
    {
        _model.ToggleFavorite(_index);
    }
}
