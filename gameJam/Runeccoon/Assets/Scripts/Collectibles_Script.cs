using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles_Script : MonoBehaviour
{
    public PlayerManager_Script PlayerManager_Script;
    public AudioClip lataSound;

    // Start is called before the first frame update
    void Start()
    {
       // PlayerManager_Script = GameObject.Find("Canvas").GetComponent<PlayerManager_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);   
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.name == "Player")
        //{
        PlayerManager_Script.latas++;
        //AudioSource.PlayerClipAtPoint(lataSound, transform.position, 0.5f);
        Destroy(gameObject);
        //}
    }
}
