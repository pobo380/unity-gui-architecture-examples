using System.Collections.Generic;
using UniRx;

public class CharacterListModel
{
    // properties

    private ReactiveCollection<Character> _list;

    public IReadOnlyReactiveCollection<Character> List
    {
        get { return _list; }
    }

    public IEnumerable<Character> ListEnumerable
    {
        get { return _list; }
    }

    // public methods

    public CharacterListModel()
    {
        _list = new ReactiveCollection<Character>();
    }

    public void SetupWithDummyData()
    {
        foreach (var item in CharacterMasterDataProvider.Instance.AllCharactersEnumerable)
        {
            _list.Add(item);
        }
    }
}
