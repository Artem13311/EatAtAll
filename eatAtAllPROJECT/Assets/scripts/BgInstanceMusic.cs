using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgInstanceMusic : MonoBehaviour
{

    [SerializeField] private string sourceTag;


    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag(this.sourceTag);
        if (obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = sourceTag;
            DontDestroyOnLoad(this.gameObject);
        }
    }


  

}
