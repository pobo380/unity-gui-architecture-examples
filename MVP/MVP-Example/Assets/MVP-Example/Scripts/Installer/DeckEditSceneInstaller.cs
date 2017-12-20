using System.Collections.Generic;
using UnityEngine;

public class DeckEditSceneInstaller : MonoBehaviour
{
    // properties

    [SerializeField]
    private CharacterFacePanelView[] _deckFacePanels;

    private List<CharacterFacePanelPresenter> _facePanelPresenters;
    private DeckModel _deckModel;

    // unity callbacks

    private void Awake()
    {
        _deckModel = new DeckModel();
        _facePanelPresenters = new List<CharacterFacePanelPresenter>();

        for (int i = 0; i < _deckFacePanels.Length; i++)
        {
            _deckFacePanels[i].Setup();

            var presenter = new CharacterFacePanelPresenter(_deckFacePanels[i], _deckModel);
            presenter.Setup(i);
            _facePanelPresenters.Add(presenter);
        }

        _deckModel.Reset();
    }
}
