using UniRx;

public class DeckModel
{
    // properties

    private ReactiveCollection<int> _characterIDs;
    private ReactiveCollection<bool> _selectState;

    public IReadOnlyReactiveCollection<int> CharacterIDs
    {
        get { return _characterIDs; }
    }

    public IReadOnlyReactiveCollection<bool> SelectState
    {
        get { return _selectState; }
    }

    // public methods

    public DeckModel()
    {
        _characterIDs = new ReactiveCollection<int>();

        _characterIDs.Add(0);
        _characterIDs.Add(0);
        _characterIDs.Add(0);

        _selectState = new ReactiveCollection<bool>();

        _selectState.Add(false);
        _selectState.Add(false);
        _selectState.Add(false);
    }

    public void Reset()
    {
        for (int i = 0; i < _characterIDs.Count; i++)
        {
            _characterIDs[i] = 0;
            _selectState[i] = false;
        }
    }

    public void SelectCharacter(int index)
    {
        for (int i = 0; i < _selectState.Count; i++)
        {
            bool selected = i == index;

            if (_selectState[i] && selected)
            {
                _selectState[i] = false;
            }
            else if (_selectState[i] != selected)
            {
                _selectState[i] = selected;
            }
        }
    }

    public void SetCharacter(int characterId)
    {
        int index;
        if (SelectedIndex(out index))
        {
            _characterIDs[index] = characterId;
        }
    }

    private bool SelectedIndex(out int index)
    {
        index = -1;

        for (int i = 0; i < _selectState.Count; i++)
        {
            if (_selectState[i])
            {
                index = i;
                return true;
            }
        }

        return false;
    }
}
