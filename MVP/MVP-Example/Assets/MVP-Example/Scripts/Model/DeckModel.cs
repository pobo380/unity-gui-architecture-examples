using UniRx;

public class DeckModel
{
    // properties

    private ReactiveCollection<int> _characterIDs;

    public IReadOnlyReactiveCollection<int> CharacterIDs
    {
        get { return _characterIDs; }
    }

    // public methods

    public DeckModel()
    {
        _characterIDs = new ReactiveCollection<int>();

        // 初期値を追加
        _characterIDs.Add(0);
        _characterIDs.Add(0);
        _characterIDs.Add(0);
    }

    public void Reset()
    {
        for (int i = 0; i < _characterIDs.Count; i++)
        {
            _characterIDs[i] = 0;
        }
    }
}
