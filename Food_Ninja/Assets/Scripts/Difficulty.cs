using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button _button;
    private GameManager _gameManager;
    public int difficulty;


    void Start()
    {
        _button = GetComponent<Button>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        _button.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetDifficulty()
    {
        _gameManager.StartGame(difficulty);
        Debug.Log(gameObject.name + " was Clicked.");
    }
}
