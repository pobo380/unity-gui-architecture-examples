using UniRx;

public class CharacterSelectIndicatorPresenter
{
    // properties

    private CharacterSelectIndicatorView _view;
    private DeckModel _model;
    private int _index;

    // public methods

    public CharacterSelectIndicatorPresenter(CharacterSelectIndicatorView view, DeckModel model)
    {
        _view = view;
        _model = model;
    }

    public void Setup(int index)
    {
        _index = index;
        _model.SelectState.ObserveReplace().Where(prop => prop.Index == _index).Subscribe(prop => RefreshView(prop));
    }

    // private methods

    private void RefreshView(CollectionReplaceEvent<bool> prop)
    {
        bool selected = prop.NewValue;
        _view.SetVisible(selected);
    }
}
