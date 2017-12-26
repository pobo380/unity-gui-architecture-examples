using System.Collections.Generic;
using UniRx;

public class CharacterListModel
{
    // properties

    private ReactiveCollection<Character> _list;
    private ReactiveCollection<bool> _isFavorite;

    public IReadOnlyReactiveCollection<Character> List
    {
        get { return _list; }
    }

    public IReadOnlyReactiveCollection<bool> IsFavorite
    {
        get { return _isFavorite; }
    }

    public IEnumerable<Character> ListEnumerable
    {
        get { return _list; }
    }

    public IEnumerable<bool> IsFavoriteEnumerable
    {
        get { return _isFavorite; }
    }

    // public methods

    public CharacterListModel()
    {
        _list = new ReactiveCollection<Character>();
        _isFavorite = new ReactiveCollection<bool>();
    }

    public void SetupWithDummyData()
    {
        foreach (var item in CharacterMasterDataProvider.Instance.AllCharactersEnumerable)
        {
            _list.Add(item);
            _isFavorite.Add(false);
        }
    }

    public void ToggleFavorite(int index)
    {
        _isFavorite[index] = !_isFavorite[index];
    }
}
