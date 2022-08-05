using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [Header("Variables")]
    public int topScore;
    public string topPlayer;
    public int thisScore;
    public string thisPlayer = "none";
    [Space(16)]
    [Header("Objects")]
    [SerializeField] TMP_InputField playerName;
    [SerializeField] Button btnPlay;

    private void Awake()
    {
        if (GameObject.Find("GameManager"))
        {
            DontDestroyOnLoad(GameObject.Find("GameManager"));
        }
        
    }


    void Start()
    {
        topScore = PlayerPrefs.GetInt("topScore");
        topPlayer = PlayerPrefs.GetString("thePlayer");
            
    }
    
    void Update()
    {
       
    }


    public void CheckName()
    {
        if (string.IsNullOrWhiteSpace(playerName.text))
        {
            btnPlay.interactable = false;
        }
        else
        {
            thisPlayer = playerName.text.ToString();            
            btnPlay.interactable = true;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
