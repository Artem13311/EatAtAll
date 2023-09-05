using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartLevels : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void setLevel1()
    {
        PlayerPrefs.SetInt("levels", 1);

    }

    public void setLevel28()
    {
        PlayerPrefs.SetInt("levels", 28);
    }
}
