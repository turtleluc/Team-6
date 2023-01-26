using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private List<Character> _characters;

    [SerializeField]
    private GameObject _characterPrefab;

    [SerializeField]
    private CharacterMoods _aliceMoods;

    [SerializeField]
    private CharacterMoods _playerMoods;

    private void Start()
    {
    _characters = new List<Character>();
    }
}
