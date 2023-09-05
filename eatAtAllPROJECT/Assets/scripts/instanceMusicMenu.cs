using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class instanceMusicMenu : MonoBehaviour
{
    [Header("music")]
    public AudioSource mainMenu;
    public AudioClip[] audioArray;


    [Header("settings")]

    [SerializeField] private TMP_Text text;
    [SerializeField] private string savedVolume;
    [SerializeField] private float volume;
    [SerializeField] private Slider slider;
    [Header("Tags")]
    [SerializeField] private string sliderTag;
    [SerializeField] private string textTag;



    private void Awake()
    {

        if (PlayerPrefs.HasKey(this.savedVolume))
        {
            this.volume = PlayerPrefs.GetFloat(this.savedVolume);
            this.mainMenu.volume = this.volume;
            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if (sliderObj != null)
            {
                this.slider = sliderObj.GetComponent<Slider>();
                this.slider.value= this.volume;
            }
            else
            {
                this.volume = 0.5f;
                PlayerPrefs.SetFloat(this.savedVolume, this.volume);
                this.mainMenu.volume = this.volume;
            }
        }
        //GameObject obj = GameObject.FindWithTag(this.sourceTag);
        //if (obj != null)
        //{
        //    Destroy(this.gameObject);
        //}
        //else
        //{
        //    this.gameObject.tag = this.sourceTag;
        //    DontDestroyOnLoad(this.gameObject);

        //}
    }

    

    
    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.volume = slider.value;

            if (this.mainMenu.volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.savedVolume, this.volume);
            }

            GameObject textObj = GameObject.FindWithTag(this.textTag);

            if (textObj != null)
            {
                this.text = textObj.GetComponent<TMP_Text>();
                this.text.text = Mathf.Round(this.volume * 100) + "%";
            }
        }
        this.mainMenu.volume = this.volume;
    }


    private void Start()
    {
        mainMenu = FindObjectOfType<AudioSource>();
        mainMenu.loop = false;
    }

    private void Update()
    {
        if (!mainMenu.isPlaying)
        {
            mainMenu.clip = audioArray[Random.Range(0, audioArray.Length)];
            mainMenu.Play();

        }
    }
 


}
