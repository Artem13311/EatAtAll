using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class setLanguageLevels : MonoBehaviour
{


    public TextMeshProUGUI nextLvlText;
    public TextMeshProUGUI getBackText;
    public TextMeshProUGUI MainMenu;
    public TMP_Text mainMenuText;
    public TMP_Text levelComplited;





    void Start()
    { 
        setLangLevels();
    }

   

    public void setLangLevels()
    {
        switch (Language.Instance.CurrentLanguage)
        {
            case "ru":
                nextLvlText.text = "Продолжить";
                getBackText.text = "Вернуться";
                MainMenu.text = "Главное меню";
                levelComplited.text = "УРОВЕНЬ ПРОЙДЕН";
                mainMenuText.text = "Меню игры";
                break;

            case "en":
                nextLvlText.text = "Continue";
                getBackText.text = "Back";
                MainMenu.text = "Main menu";
                levelComplited.text = "LEVEL COMPLETED";
                mainMenuText.text = "Game menu";
                break;

            case "tr":
                nextLvlText.text = "Devam et";
                getBackText.text = "Geri dön";
                MainMenu.text = "Ana menü";
                levelComplited.text = "SEVİYE GEÇTİ";

                mainMenuText.text = "Oyun menüsü";
                break;

        }
    }

   
}
