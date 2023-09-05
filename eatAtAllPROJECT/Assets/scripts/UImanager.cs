using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour
{

    #region Singleton class: UImanager

    public static UImanager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    #endregion
    [Header("Level Progress UI")]
    [SerializeField] int sceneOffset;
    [SerializeField] TMP_Text nextLevelText;
    [SerializeField] TMP_Text currentLevelText;
    [SerializeField] Image progressFillImage;

    [SerializeField] TMP_Text passLevel;
    [Header("Menu Pause")]

    [SerializeField] GameObject UICanvas;

    [SerializeField] public Button pauseBtn;
    [SerializeField] GameObject pauseCanvas;
    [SerializeField] Button goToMainMenu;
    [SerializeField] Button audioOff;








    void Start()
    {
        progressFillImage.fillAmount = 0f;
        setLevelProgressText();
        passLevel.enabled = false;
             
    }
    void setLevelProgressText()
    {
        int level = SceneManager.GetActiveScene().buildIndex + sceneOffset;
        currentLevelText.text = (level-1).ToString();
        nextLevelText.text = (level).ToString();

    }
    public void UpdateLevelProgress()
    {
        float val = 1f - ((float)level.Instance.objectInScene / level.Instance.totalObjects);
        progressFillImage.fillAmount = val;
    }

  

    public void showPauseMenu()
    {
        Game.gameIsPaused = true;
        UICanvas.SetActive(false);
        pauseCanvas.SetActive(true);

    }
    public void gotoMainMenu()
    {
        SceneManager.LoadScene(0);
        
    }

    public void exitPauseMenu()
    {
        Game.gameIsPaused = false;
        UICanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    public void showLevelCompleted()
    {
        passLevel.enabled = true;
    }

   
}
