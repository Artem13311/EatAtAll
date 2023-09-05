using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{

    #region Singleton class: level

    public static level Instance;

    void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
        }
      
    }

    #endregion
    [SerializeField] ParticleSystem particles;
    [Space]
    public int objectInScene;
    public int totalObjects;

    [SerializeField] Transform objectsParent;
    void Start()
    {
        CountObjects();
    }

    void CountObjects()
    {
        totalObjects = objectsParent.childCount;
        objectInScene = totalObjects;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void PlayParticles()
    {
        particles.Play();
    }
}
