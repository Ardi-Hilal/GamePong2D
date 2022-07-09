using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject HTPPanel;
    public GameObject TimerPanel;

    public GameObject BallPanel;
    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);    
        BallPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SinglePlayerButton()
    {
        GameData.instance.isSinglePlayer = true; 
        TimerPanel.SetActive(true);
        BallPanel.SetActive(false);
        Debug.Log("singelplayer");
        SoundManager.instance.UIClickSfx();
    }

    public void MultiPlayerButton()
    {
        GameData.instance.isSinglePlayer = false;
        TimerPanel.SetActive(true);
        BallPanel.SetActive(false);
        Debug.Log("multiplayer" );
        SoundManager.instance.UIClickSfx();
    }

    public void BackButton()
    {
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        BallPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }

    public void SetTimerButton(float Timer)
    {
        GameData.instance.gameTimer = Timer;
        BallPanel.SetActive(true);
        TimerPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }
    public void SetBall(GameObject Bola) {
        GameData.instance.Ball = Bola;
        HTPPanel.SetActive(true);
        BallPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }

    public void StartBtn()
    {
        SceneManager.LoadScene("2. Gameplay");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
