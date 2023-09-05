using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class setLanguage : MonoBehaviour
{
    public TextMeshProUGUI play;
    public TextMeshProUGUI levels;
    public TextMeshProUGUI back;


    void Start()
    {
        setLangMainMenu();
    }

    public void setLangMainMenu()
    {


        switch (Language.Instance.CurrentLanguage)
        {
            case "ru":
                play.text = "Играть";
                levels.text = "Уровни";
                back.text = "Вернуться";
                break;

            case "en":
                play.text = "Play";
                levels.text = "Levels";
                back.text = "Back";

                break;

            case "tr":
                play.text = "Oyuna başla";
                levels.text = "Düzeyler";
                back.text = "Geri dön";
                break;
            default:
                play.text = "Play";
                levels.text = "Levels";
                back.text = "Back";


                break;
        }
    }



}
