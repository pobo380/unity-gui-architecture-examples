using System.Collections.Generic;
using UnityEngine;

public class DeckEditSceneInstaller : MonoBehaviour
{
    // properties

    [SerializeField]
    private CharacterFacePanelView[] _deckFacePanels;

    [SerializeField]
    private CharacterSelectListView _characterSelectListView;

    private List<CharacterFacePanelPresenter> _facePanelPresenters;
    private CharacterSelectListPresenter _characterSelectListPresenter;

    private DeckModel _deckModel;
    private CharacterListModel _characterListModel;

    // unity callbacks

    private void Awake()
    {
        SetupDeck();
        SetupCharacterList();
    }

    // private methods
    
    private void SetupDeck()
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

    private void SetupCharacterList()
    {
        _characterListModel = new CharacterListModel();
        _characterListModel.SetupWithDummyData();

        _characterSelectListView.Setup();

        _characterSelectListPresenter = new CharacterSelectListPresenter(_characterSelectListView, _characterListModel);
        _characterSelectListPresenter.Setup();
    }
}
