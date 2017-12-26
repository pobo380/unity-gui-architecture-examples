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

    public void Setup(DeckModel deckModel)
    {
        int index = 0;
        foreach (var item in _model.ListEnumerable)
        {
            var view = _view.AddPanel();
            var presenter = new CharacterSelectPanelPresenter(view, item, deckModel);
            presenter.Setup();

            var favoriteView = view.GetComponent<FavoriteStarView>();
            var favoritePresenter = new FavoriteStarPresenter(favoriteView, _model);

            favoriteView.Setup();
            favoritePresenter.Setup(index);

            index++;
        }
    }
}
