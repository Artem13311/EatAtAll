using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class levels : MonoBehaviour
{
    public Button[] buttons;

    private void Start()
    {
       
      
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
            for (int i = 0; i < menuManager.LevelInLock - 1; i++)
            {
                buttons[i].interactable = true;
            }
        
    }


    public void loadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

   

}
