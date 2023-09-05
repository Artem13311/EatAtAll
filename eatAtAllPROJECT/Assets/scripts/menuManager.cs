using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public static int LevelInLock;

    public Button startButton;
    public Button levels;

    public GameObject levelsPanel;
    [SerializeField] GameObject sliderEmptyAndText;


    void Start()
    {
        LevelInLock = PlayerPrefs.GetInt("levels",1);

        sliderEmptyAndText.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene(LevelInLock);

    }
    public void openLevels()
    {
        levelsPanel.SetActive(true);
        sliderEmptyAndText.SetActive(false);
    }
    public void getBack()
    {
        levelsPanel.SetActive(false);

    }

  


    public void getBackToMenu()
    {
        levelsPanel.SetActive(false);
        sliderEmptyAndText.SetActive(true);

    }




}
