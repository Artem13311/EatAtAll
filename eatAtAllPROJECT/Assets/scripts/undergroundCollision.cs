using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class undergroundCollision : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] GameObject buttonCanvas;

    [SerializeField] Button btnNextLevel;




    void OnTriggerEnter(Collider other)
    {

        if (!Game.isGameOver)
        {
            string tag = other.tag;
            if (tag.Equals("Object"))
            {
                FindAnyObjectByType<gameSounds>().playPortalSound();

                level.Instance.objectInScene--;
                UImanager.Instance.UpdateLevelProgress();
                Destroy(other.gameObject);
                if (level.Instance.objectInScene == 0)
                {
                    FindAnyObjectByType<gameSounds>().playWinSound();
                    offPauseBtn();
                    buttonCanvas.SetActive(true);
                    UnlockLevel();
                    UImanager.Instance.showLevelCompleted();
                    level.Instance.PlayParticles();
                    Game.isLevelPassed = true;
                    
                }
            }
            if (tag.Equals("Obstacle"))
            {
                FindAnyObjectByType<gameSounds>().playDeathSound();

                Destroy(other.gameObject);
                offPauseBtn();
                Game.isGameOver = true;

                Invoke("restartLevel", 3.5f);


            }
        }
        

    }

    void offPauseBtn()
    {
        UImanager.Instance.pauseBtn.enabled = false;
    }
    public void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", currentLevel + 1);
        }
    }
    private void Update()
    {
        if(Game.isGameOver == true)
        {
            StartCoroutine(c_Alpha(1,3.5f));
        }
    }



    public void nextLevel()
    {
        level.Instance.LoadNextLevel();

    }

    void restartLevel()
    {
        level.Instance.RestartLevel();

    }
    private void Start()
    {
        buttonCanvas.SetActive(false);

    }


    IEnumerator c_Alpha(float value, float time)
    {
        float k = 0.0f;
        Color c0 = fadeImage.color;
        Color c1 = c0;
        c1.a = value;

        while ((k += Time.deltaTime) <= time)
        {
            fadeImage.color = Color.Lerp(c0, c1, k / time);

            yield return null;
        }

        fadeImage.color = c1;
    }
}



