using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager_Script : MonoBehaviour
{
    #region Singleton
    public static PlayerManager_Script instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

   
    
    public GameObject player;
    
    //public Text LataText;
    public int latas = 0;

    void Update()
    {
       // LataText.Text = "Spraycans : " + latas;
    }

    private void OnGUI()
    {
       // GUI.Label(new Rect(10,10,100,20), "Spraycans : " + latas);
    }
}