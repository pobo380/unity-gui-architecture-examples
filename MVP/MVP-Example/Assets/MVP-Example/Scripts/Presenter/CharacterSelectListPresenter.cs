public class CharacterSelectListPresenter
{
    // properties

    private CharacterSelectListView _view;
    private CharacterListModel _model;

    // public methods

    public CharacterSelectListPresenter(CharacterSelectListView view, CharacterListModel model)
    {
        _view = view;
        _model = model;
    }

    public void Setup()
    {
        foreach (var item in _model.ListEnumerable)
        {
            var view = _view.AddPanel();
            var presenter = new CharacterSelectPanelPresenter(view, item);
            presenter.Setup();
        }
    }
}
