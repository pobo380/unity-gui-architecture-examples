using UniRx;

public class CharacterModel
{
    // properties

    private ReactiveProperty<bool> _favorite;

    public IReadOnlyReactiveProperty<bool> Favorite
    {
        get { return _favorite; }
    }

    // public method
}
