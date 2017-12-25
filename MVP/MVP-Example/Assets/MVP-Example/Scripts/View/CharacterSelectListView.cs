using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class CharacterSelectListView : MonoBehaviour
{
    // properties

    [SerializeField]
    private CharacterSelectPanelView _selectPanelPrefab;

    [SerializeField]
    private Transform _contentRoot;

    private List<CharacterSelectPanelView> _panelList;

    // public methods

    public void Setup()
    {
        _panelList = new List<CharacterSelectPanelView>();
    }

    public CharacterSelectPanelView AddPanel()
    {
        var panel = Instantiate(_selectPanelPrefab, _contentRoot, false);
        _panelList.Add(panel);
        panel.Setup();

        return panel;
    }
}
