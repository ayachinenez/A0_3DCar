using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GAMETYPE { SINGLE,MULTI};

public class StartMenu : MonoBehaviour
{
    public GameObject panelA;
    public GameObject panelB;
    public GAMETYPE gameType = GAMETYPE.SINGLE;

    public GameObject btnplay;
    public GameObject btnpsingle;
    public GameObject btnpmulti;
    public GameObject btnpquit;


    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        panelB.SetActive(false);

        //Play-> PlayA
        Button btn1 = btnplay.GetComponent<Button>();
        btn1.onClick.AddListener(playA);

        //Single->PlaySingle
        Button btn2 = btnpsingle.GetComponent<Button>();
        btn2.onClick.AddListener(playSingle);

        //Multi->PlayMulti
        Button btn3 = btnpmulti.GetComponent<Button>();
        btn3.onClick.AddListener(playMulti);

        //Quit->Quit
        Button btn4 = btnpquit.GetComponent<Button>();
        btn4.onClick.AddListener(Quit);
    }

    public void playA()
    {
        panelA.SetActive(false);
        panelB.SetActive(true);
    }

    public void playSingle()
    {
        gameType = GAMETYPE.SINGLE;
        PlayerPrefs.SetString("GAMETYPE", "SINGLE");
        SceneManager.LoadScene(1);
    }

    public void playMulti()
    {
        gameType = GAMETYPE.MULTI;
        PlayerPrefs.SetString("GAMETYPE", "MULTI");
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
