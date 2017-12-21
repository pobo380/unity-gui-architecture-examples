using UniRx;

public class DeckModel
{
    // properties

    private ReactiveCollection<int> _characterIDs;
    private ReactiveCollection<bool> _isSelected;

    public IReadOnlyReactiveCollection<int> CharacterIDs
    {
        get { return _characterIDs; }
    }

    // public methods

    public DeckModel()
    {
        _characterIDs = new ReactiveCollection<int>();

        _characterIDs.Add(0);
        _characterIDs.Add(0);
        _characterIDs.Add(0);

        _isSelected = new ReactiveCollection<bool>();

        _isSelected.Add(false);
        _isSelected.Add(false);
        _isSelected.Add(false);
    }

    public void Reset()
    {
        for (int i = 0; i < _characterIDs.Count; i++)
        {
            _characterIDs[i] = 0;
            _isSelected[i] = false;
        }
    }

    public void SelectCharacter(int index)
    {
        for (int i = 0; i < _isSelected.Count; i++)
        {
            bool selected = i == index;

            if (_isSelected[i] != selected)
            {
                _isSelected[i] = selected;
            }
        }
    }

    public void SetCharacter(int index, int characterId)
    {
        _characterIDs[index] = characterId;
    }
}
